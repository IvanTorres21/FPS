using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteracteableObjectController : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] private Vector3 prevSpeed;
    private Vector3 angSpeed;
    public float impactForce;
    private PlayerTimeController timeController;
    private bool timeHasPaused = false;
    public bool isHatch = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        timeController = FindObjectOfType<PlayerTimeController>();
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Z) && timeController.isTimePaused)
        {
            prevSpeed = rb.velocity;
            timeHasPaused = true;
            if (!isHatch) rb.isKinematic = true;
        } else if (!timeController.isTimePaused && timeHasPaused)
        {
            if(!isHatch) rb.isKinematic = false;
            rb.velocity = prevSpeed;
            timeHasPaused = false;
        }
       if(timeHasPaused)
        {
            rb.velocity = rb.velocity * timeController.slowdown;
            rb.angularVelocity = rb.angularVelocity * timeController.slowdown;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BulletSmall") && rb.useGravity)
        {
            rb.AddForce(collision.contacts[0].normal * impactForce, ForceMode.Impulse);
        }
    }
}
