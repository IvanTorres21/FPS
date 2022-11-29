using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SegmentController : MonoBehaviour
{
    [SerializeField] public Rigidbody rb { get; private set; }
    private PlayerTimeController playerTimeController;
    [SerializeField] private bool isHead;
    private GameObject wormGuide;
    public int damage;

    private void Start()
    {
        playerTimeController = FindObjectOfType<PlayerTimeController>();
        rb = GetComponent<Rigidbody>();
        wormGuide = GameObject.Find("WormGuide");
        damage = wormGuide.GetComponent<WormGuide>().damage;
    }

    private void Update()
    {
        if(wormGuide != null)
        {
            rb.velocity = transform.forward.normalized * wormGuide.GetComponent<WormGuide>().speed * playerTimeController.slowdown;
            rb.angularVelocity = rb.angularVelocity * playerTimeController.slowdown;
        } else
        {
            damage = 0;
            rb.useGravity = true;
            this.gameObject.layer = 0;
        }
    }

    public void ExplosionHit(int damage)
    {
        wormGuide.GetComponent<WormGuide>().GetHurt(isHead ? damage : damage / 5);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("BulletSmall"))
        {
            BulletController bc;
            if (collision.gameObject.TryGetComponent<BulletController>(out bc))
            {
               if(wormGuide != null)
                {
                    wormGuide.GetComponent<WormGuide>().GetHurt(isHead ? bc.damage : bc.damage / 5);
                }
            }
        }
    }
}
