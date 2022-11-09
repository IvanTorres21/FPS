using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{

    Rigidbody rb;
    public float speed = 25f;
    private int ricochetAmount = 0;
    private Vector3 currentSpeed;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        currentSpeed = rb.velocity;
    }


    private void Update()
    {
        rb.velocity = currentSpeed * FindObjectOfType<PlayerTimeController>().slowdown;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(ricochetAmount >= 3)
        {
            Destroy(this.gameObject);
        }
        Vector3 forward = transform.forward;
        Vector3 normal = collision.contacts[0].normal;

        Vector3 newSpeed = -2 * (Vector3.Dot(forward, normal) * normal) + forward;
        speed = speed * 0.7f;
        currentSpeed = speed * newSpeed;
        ricochetAmount++;
    }
}
