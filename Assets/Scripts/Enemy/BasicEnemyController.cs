using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;
using Random = UnityEngine.Random;

public class BasicEnemyController : MonoBehaviour
{
    [SerializeField] private GameObject player;
    [SerializeField] private List<Vector3> paths;

    [SerializeField] public int hp { get; private set; } = 25;
    [SerializeField] public int damage { get; private set; } = 30;

    private Rigidbody rb;
    private float speed = 6f;
    private const float maxSpeed = 6f;
    private float jumpForce = 3f;
    private bool isGrounded;

    private PlayerTimeController timeController;
    private bool isFollowing = false;
    private bool hasBeenAttacked = false;
    private bool timeHasBeenPaused = false;
    private float confusionTime = 3f;
    private Quaternion lastRotation;
    private Vector3 lastVelocity;

    [SerializeField] private Vector3 maxLookAround;
    [SerializeField] private Vector3 minLookAround;

    [SerializeField] private bool isAttacking = false;
    private Vector3 wanderPosition;
    public Vector3 wanderPos;
    private void Start()
    {
        timeController = FindObjectOfType<PlayerTimeController>();
        player = GameObject.Find("Player");
        rb = GetComponent<Rigidbody>();
        InvokeRepeating(nameof(UpdatePaths), 0.0f, 0.4f);
        wanderPosition = transform.position;
        wanderPos = transform.position;
    }

    private void Update()
    {

        ControlBehaviour();
        speed = maxSpeed * timeController.slowdown;

        if(!timeHasBeenPaused)
        {
            lastRotation = transform.rotation;
        }

        if(timeController.isTimePaused)
        {
            rb.useGravity = false;
            StopAllCoroutines();
            timeHasBeenPaused = true;
            transform.rotation = lastRotation;
            lastVelocity = rb.velocity;
            rb.velocity = Vector3.zero;
         
        }
        if(timeHasBeenPaused && !timeController.isTimePaused)
        {
            rb.useGravity = true;
            rb.velocity = lastVelocity;
            StartCoroutine(RecoveryTime());
        }
    }

    private void ControlBehaviour()
    {
       
        if((Vector3.Distance(transform.position, player.transform.position) <= 30f))
        {
            // If there are twenty or more enemies they act as a hive
            if (gameObject.transform.parent.transform.childCount >= 20)
            {
                if (!timeHasBeenPaused)
                {
                    transform.LookAt(player.transform);
                }

                if (!timeHasBeenPaused)
                {
                    FollowPlayer();
                }
                else
                {
                    isFollowing = false;
                    StopCoroutine(followingJumps());
                }
            } 
            else // If there are less than twenty they try to surround the player and become erratic in movement
            {
                if(!timeHasBeenPaused)
                {
                    SurroundPlayer();
                } else
                {
                    isFollowing = false;
                    StopCoroutine(followingJumps());
                }
            }
        } else
        {
            WanderAround();
        }

        if(timeHasBeenPaused && !timeController.isTimePaused)
        {
           if(!isLookingAround)  StartCoroutine(LookAroundInConfusion());
        }
    }
    private void FollowPlayer()
    {
        if(!isFollowing)
        {
            StartCoroutine(followingJumps());
        }
        
        if(paths.Count > 0)
        {
          
            rb.velocity = new Vector3(transform.forward.x * speed, rb.velocity.y, transform.forward.z * speed );
            
            if (transform.position == paths[0] + new Vector3(0, 0.4f, 0))
            {
                paths.RemoveAt(0);
            }
        }
    }

   
    private void WanderAround()
    {
        if(Vector3.Distance(transform.position, wanderPos) <= 0.4f)
        {
            wanderPos = wanderPosition + new Vector3(Random.Range(-2, 2), this.transform.position.y, Random.Range(-2, 2));
            wanderPos.y = this.transform.position.y;
        } else
        {
            transform.LookAt(wanderPos);
            rb.velocity = new Vector3(transform.forward.x * speed, rb.velocity.y, transform.forward.z * speed);
        }
    }

    private bool inPosition = false;
    private void SurroundPlayer()
    {
        if(!isFollowing)
        {
            StartCoroutine(followingJumps());
        }
        float amountOfCompanions = (float)gameObject.transform.parent.transform.childCount / (float)360;
        float thisPositionInCircle = (amountOfCompanions * gameObject.transform.GetSiblingIndex() * 720) + 360;

        Vector3 newPos = new Vector3(5 * Mathf.Sin(thisPositionInCircle) + player.transform.position.x, this.transform.position.y, 5 * Mathf.Cos(thisPositionInCircle) + player.transform.position.z);
        if (Vector3.Distance(transform.position, newPos) <= 0.4f)
        {
            if(!inPosition)
            {
                StartCoroutine(RandomAttackInterval());
                inPosition = true;
            }

        } else if(Vector3.Distance(transform.position, newPos) >= 4f)
        {
            isAttacking = false;
            inPosition = false;
        }


        if (!isAttacking && !inPosition)
        {
            transform.LookAt(newPos);
            rb.velocity = new Vector3(transform.forward.x * speed, rb.velocity.y, transform.forward.z * speed);
        } else if(inPosition)
        {
            transform.LookAt(player.transform);
            if(isAttacking)
                rb.velocity = new Vector3(transform.forward.x * speed, rb.velocity.y, transform.forward.z * speed);
        }
    }

    private bool CompanionInFront()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if (Physics.Raycast(ray, 1.6f, 1 << 8))
        {
            return true;
        }
        return false;
    }

    private bool checkGrounded()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        if (Physics.Raycast(ray, 1.6f, 1 << 0))
        {
            return true;
        }
        return false;

    }

    IEnumerator RandomAttackInterval()
    {
        yield return new WaitForSeconds(Random.Range(1f, 3f));
        isAttacking = true;
    }

    IEnumerator followingJumps()
    {
        isFollowing = true;
        while (isFollowing)
        {
            yield return new WaitForSeconds(0.4f);
            if(checkGrounded()) rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }

    IEnumerator RecoveryTime()
    {
        yield return new WaitForSeconds(Random.Range(0.5f, confusionTime));
        timeHasBeenPaused = false;
        isLookingAround = false;
    }

    public bool isLookingAround = false;
    IEnumerator LookAroundInConfusion()
    {
        isLookingAround = true;
        Vector3 lookPoint;
        while (timeHasBeenPaused)
        {
            lookPoint = transform.position + new Vector3(Random.Range(minLookAround.x, maxLookAround.x), Random.Range(minLookAround.y, maxLookAround.y), Random.Range(minLookAround.z, maxLookAround.z));

            transform.LookAt(lookPoint);

            yield return new WaitForSeconds(0.25f);
        }
        isLookingAround = false;
    }


    private void UpdatePaths()
    {
        NavMeshPath nav = new NavMeshPath();
        NavMesh.CalculatePath(transform.position, player.transform.position, NavMesh.AllAreas, nav);
        paths = nav.corners.ToList<Vector3>();
    }

    public void TakeDamage(int dmg)
    {
        hp -= dmg;
        if(hp < 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BulletSmall"))
        {
            hasBeenAttacked = true;
            BulletController bc;
            if (collision.gameObject.TryGetComponent<BulletController>(out bc))
            {
                TakeDamage(bc.damage);
            }
        }
    }
}
