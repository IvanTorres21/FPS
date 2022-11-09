using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracteableObjectController : MonoBehaviour
{
    Rigidbody rb;
    public Vector3 prevSpeed;
    public Vector3 angSpeed;
    public float impactForce;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Z) && FindObjectOfType<PlayerTimeController>().isTimePaused)
        {
            rb.useGravity = false;
            prevSpeed = rb.velocity;

            Debug.Log("Time Stopped");
              
        } else if(Input.GetKeyUp(KeyCode.Z))
        {
            rb.useGravity = true;
            rb.velocity = prevSpeed;

            Debug.Log("Time Resumed");
        }
        rb.velocity = rb.velocity * FindObjectOfType<PlayerTimeController>().slowdown;
        rb.angularVelocity = rb.angularVelocity * FindObjectOfType<PlayerTimeController>().slowdown;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BulletSmall"))
        {
            rb.AddForce(collision.contacts[0].normal * impactForce, ForceMode.Impulse);
        }
    }
}
