using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingGround : MonoBehaviour
{
    [SerializeField] private int hp = 100;


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
