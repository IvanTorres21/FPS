using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakingGround : MonoBehaviour
{

    [SerializeField] private int hp = 100;
    private SpringJoint springJoint;
    private bool isSpring;
    public bool isLock = false;

    private void Start()
    {
        if(TryGetComponent<SpringJoint>(out springJoint))
        {
            isSpring = true;
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
            if(isLock)
            {
                transform.parent.Find("Hatch").GetComponent<Rigidbody>().isKinematic = false;
                transform.parent.Find("Hatch").GetComponent<InteracteableObjectController>().isHatch = false;
            }
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
