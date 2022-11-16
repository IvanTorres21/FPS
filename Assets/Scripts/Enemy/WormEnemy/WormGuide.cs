using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WormGuide : MonoBehaviour
{
    public bool isActive = false;


    public int hp = 1000;
    [SerializeField] public int damage { get; private set; } = 100;
    [SerializeField] private Image hpBar;
    [SerializeField] private GameObject bossHPBar;

    private bool isDigging;
    private bool returningHome;
    private bool isAboutToAttack;
    private bool isAttacking;
    private bool controlPointReached;

    [SerializeField] private GameObject player;
    [SerializeField] private SegmentController head;
    [SerializeField] private GameObject referencePoint;
    private PlayerTimeController playerTimeController;
    private Rigidbody rb;

    [SerializeField] public float speed { get; private set; } = 40f;
    private Vector2 timeBetweenAttacks = new Vector2(3f, 9f);
    private float waitBeforeNextAttack = 2f;
    private float waitBetweenFragments = 0.2f;
    private float waitRepeatBehaviour = 1f;

    private List<Vector3> closestPoints = new List<Vector3>();
    private float closestDistance;
    private Vector3 nextPoint = Vector3.zero;

    public GameObject test;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerTimeController = FindObjectOfType<PlayerTimeController>();
        CheckForClosestPoint();
        StartCoroutine(ControlBehaviour());
    }

    private void Update()
    {
        rb.velocity = transform.forward.normalized * speed * playerTimeController.slowdown;

    }

    private void CheckForClosestPoint()
    {
        closestPoints.Clear();
        RaycastHit hit;
        isDigging = true;
        closestDistance = Mathf.Infinity;
        for (int i = 0; i < 9; i++)
        {
            float degreeS = (i / 8f) * 360;
            for(int j = 0; j < 9; j++)
            {
                float degreeT = (j / 8f) * 360;
                Vector3 pos = GetPointInSphere(degreeS, degreeT, 10);
                //Instantiate(test, transform.position + pos, Quaternion.identity, transform);
                if (Physics.Raycast(transform.position, pos.normalized , out hit, Mathf.Infinity, 1 << 10))
                {
                    if (hit.distance < closestDistance)
                    {
                        closestDistance = hit.distance;
                        closestPoints.Add(hit.point);
                    }
                }
            }
        }
        if (closestPoints.Count > 0)
            nextPoint = closestPoints[Random.Range(0, closestPoints.Count)];
        else
            nextPoint = referencePoint.transform.position;
        controlPointReached = false;
    }

    private Vector3 GetPointInSphere(float s, float t, float r)
    {
        s = Mathf.Deg2Rad * s;
        t = Mathf.Deg2Rad * t;
        Vector3 point = new Vector3();
        point.x = r * Mathf.Cos(s) * Mathf.Sin(t);
        point.y = r * Mathf.Sin(s) * Mathf.Sin(t);
        point.z = r * Mathf.Cos(t);
        return point;
    }

    private Vector3 ControlPointCalculation(float t)
    {
        Vector3 point = new Vector3();

        Vector3 p0 = transform.position;
        Vector3 p1 = p0 + transform.forward;
        Vector3 p3 = nextPoint;
        Vector3 p2 = p3 - (-nextPoint.normalized);
        point = Mathf.Pow(1f - t, 3f) * p0 + 3f * Mathf.Pow(1f - t, 2f) * t * p1 + 3f * (1f - t) * Mathf.Pow(t, 2f) * p2 + Mathf.Pow(t, 3f) * p3;

        //Instantiate(test, point, Quaternion.identity);
        return point;
    }

    IEnumerator ReturnHome()
    {
        nextPoint = referencePoint.transform.position;
        int steps = 1;
        while (steps <= 2)
        {
            transform.LookAt(ControlPointCalculation(steps / 2f));
            steps++;
            yield return new WaitForSeconds(waitBetweenFragments);
        }
        controlPointReached = true;
        transform.LookAt(nextPoint);
        yield return null;  

    }

    private bool deciding = false;
    IEnumerator DecideToAttack()
    {
        deciding = true;
        yield return new WaitForSeconds(Random.Range(timeBetweenAttacks.x, timeBetweenAttacks.y));
        Debug.Log("Attacking");
        isAboutToAttack = true;
    }

    IEnumerator ControlBehaviour()
    {
        yield return new WaitForSeconds(2f);
        while (hp >= 0)
        {
            
            if(!returningHome && !isAttacking)
            {
               if(!isAboutToAttack && !deciding)
                {
                    StartCoroutine(DecideToAttack());
                }
                if (!isDigging)
                {
                    CheckForClosestPoint();
                }
                else if (isDigging && !controlPointReached)
                {
                    int steps = 1;
                    while (steps <= 2)
                    {
                        transform.LookAt(ControlPointCalculation(steps / 2f));
                        steps++;
                        yield return new WaitForSeconds(waitBetweenFragments);
                    }
                    controlPointReached = true;
                    transform.LookAt(nextPoint);
                    
                }
                if (Vector3.Distance(transform.position, referencePoint.transform.position) >= 100)
                {
                    StartCoroutine(ReturnHome());

                }
            }

            if(isAboutToAttack && !isAttacking)
            {
                nextPoint = player.transform.position;
                isAttacking = true;
                isAboutToAttack = false;

            }

            if(isAttacking)
            {
                int steps = 1;
                while (steps <= 2)
                {
                    transform.LookAt(ControlPointCalculation(steps / 2f));
                    steps++;
                    yield return new WaitForSeconds(waitBetweenFragments);
                }
                controlPointReached = true;
                transform.LookAt(nextPoint);
                isAttacking = false;
                yield return new WaitForSeconds(waitBeforeNextAttack);
                deciding = false;
            }
           
            yield return new WaitForSeconds(waitRepeatBehaviour);
        }
        yield return null;
    }

    IEnumerator ChangeDirection()
    {
        yield return new WaitForSeconds(2f);
        isDigging = false;
    }


    private void OnTriggerEnter(Collider other)
    {
        if(isDigging && other.CompareTag("Ground"))
        {
            StartCoroutine(ChangeDirection());
        }
    }

    public void GetHurt(int damage)
    {
        hp -= damage;
        hpBar.fillAmount = hp / 1000f;
        if(hp/1000f <=  0.75 && speed == 40)
        {
            speed += 10;
            waitBetweenFragments = 0.15f;
            waitRepeatBehaviour = 1f;
        } else if (hp / 1000f <= 0.5 && speed == 50)
        {
            speed += 10;
            timeBetweenAttacks.y = 7f;
            waitBetweenFragments = 0.1f;
            waitRepeatBehaviour = 0.8f;
            waitBeforeNextAttack = 1.5f;
        } else if (hp / 1000f <= 0.25 && speed == 55)
        {
            speed += 10;
            timeBetweenAttacks.x = 1f;
            timeBetweenAttacks.y = 5f;
            waitBetweenFragments = 0.08f;
            waitRepeatBehaviour = 0.7f;
            waitBeforeNextAttack = 1f;
        }
        if (hp <= 0)
        {
            bossHPBar.SetActive(false);
            Destroy(this.gameObject);
        }
    }
}
