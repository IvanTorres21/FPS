using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentController : MonoBehaviour
{
    [SerializeField] public Rigidbody rb { get; private set; }
    private PlayerTimeController playerTimeController;
    [SerializeField] private bool isHead;
    private GameObject wormGuide;

    private void Start()
    {
        playerTimeController = FindObjectOfType<PlayerTimeController>();
        rb = GetComponent<Rigidbody>();
        wormGuide = GameObject.Find("WormGuide");
    }

    private void Update()
    {
        if(wormGuide != null)
        {
            rb.velocity = transform.forward.normalized * wormGuide.GetComponent<WormGuide>().speed * playerTimeController.slowdown;
            rb.angularVelocity = rb.angularVelocity * playerTimeController.slowdown;
        }
    }

    private bool CheckDistanceIsRight()
    {
        return true;
        Ray ray = new Ray(transform.position, transform.forward);
        if(Physics.Raycast(ray, transform.parent.transform.localScale.z * transform.localScale.z + 1f, 1 << 9))
        {
            return false;
        } else
        {
            return true;
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BulletSmall"))
        {
            BulletController bc;
            if (collision.gameObject.TryGetComponent<BulletController>(out bc))
            {
                wormGuide.GetComponent<WormGuide>().GetHurt(isHead ? bc.damage : bc.damage / 5);
            }
        }
    }
}
