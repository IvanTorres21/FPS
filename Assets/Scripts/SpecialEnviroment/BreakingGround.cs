using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingGround : MonoBehaviour
{
    [SerializeField] private int hp = 100;
    private SpringJoint springJoint;
    private Rigidbody rb;
    private bool isSpring;
    private PlayerTimeController timeController;

    private void Start()
    {
        if(TryGetComponent<SpringJoint>(out springJoint))
        {
            isSpring = true;
            rb = GetComponent<Rigidbody>();
            timeController = FindObjectOfType<PlayerTimeController>();
        }
    }

    private void Update()
    {
        if(isSpring && springJoint == null)
        {
            Destroy(this.gameObject);
        }
    }

    private void TakeDamage(int damage)
    {
        hp -= damage;
        if(hp <= 0)
        {
            Destroy(this.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("BulletSmall"))
        {
            BulletController bc;
            if(collision.gameObject.TryGetComponent<BulletController>(out bc))
            {
                TakeDamage(bc.damage);
            }
            MissileController mc;
            if(collision.gameObject.TryGetComponent<MissileController>(out mc))
            {
                TakeDamage(mc.damage);
            }
        }
    }
}
