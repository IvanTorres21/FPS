using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    Rigidbody rb;
    public float speed = 85f;
    private bool canRicochet = true;
    private bool justBorn = true;
    private Vector3 currentSpeed;
    private TrailRenderer trailRenderer;
    private PlayerTimeController timeController;
    [SerializeField] public int damage { get; private set; } = 5;
    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        trailRenderer = GetComponent<TrailRenderer>();
        currentSpeed = rb.velocity;
        timeController = FindObjectOfType<PlayerTimeController>();
        StartCoroutine(justShot());
    }


    private void Update()
    {
        if(!justBorn)
            rb.velocity = currentSpeed * timeController.slowdown;

        if(timeController.isTimePaused)
        {
            trailRenderer.time = 999999;
        } else
        {
            trailRenderer.time = 0.25f;
        }
    }

    IEnumerator justShot()
    {

        yield return new WaitForSeconds(0.05f);
        justBorn = false;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Interacteable") || collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(this.gameObject);
        } else
        {
            if (!canRicochet)
            {
                Destroy(this.gameObject);
            }
            Vector3 forward = transform.forward;
            Vector3 normal = collision.contacts[0].normal;

            Vector3 newSpeed = -2 * (Vector3.Dot(forward, normal) * normal) + forward;
            speed = speed * 0.7f;
            currentSpeed = speed * newSpeed;
            canRicochet = false;
        }
    }
}
