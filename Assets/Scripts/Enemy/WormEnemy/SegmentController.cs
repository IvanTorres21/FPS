using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentController : MonoBehaviour
{
    private Rigidbody rb;
    private float speed = 12f;
    private PlayerTimeController playerTimeController;

    private void Start()
    {
        playerTimeController = FindObjectOfType<PlayerTimeController>();
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        if(CheckDistanceIsRight())
        {
            Vector3 direction = transform.forward ;
            rb.velocity = direction.normalized * speed * playerTimeController.slowdown;

        } else
        {
            rb.velocity = Vector3.zero;
        }
    }

    private bool CheckDistanceIsRight()
    {
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray, 1.3f, 1 << 9))
        {
            return false;
        } else
        {
            return true;
        }
    }
}
