using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
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
    [SerializeField] private GameObject particles;
    [SerializeField] public int damage = 5;
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
        GameObject generatedParticle = Instantiate(particles, transform.position, Quaternion.identity);
        Destroy(generatedParticle, 1f);
        if(collision.gameObject.CompareTag("Interacteable") || collision.gameObject.CompareTag("Enemy") || collision.gameObject.CompareTag("Worm"))
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
            transform.LookAt(newSpeed);
            transform.GetChild(0).transform.LookAt(newSpeed);
            speed = speed * 0.7f;
            currentSpeed = speed * newSpeed;
            canRicochet = false;
        }
    }
}
