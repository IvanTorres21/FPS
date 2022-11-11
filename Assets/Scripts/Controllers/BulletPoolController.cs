using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPoolController : MonoBehaviour
{
    private void FixedUpdate()
    {
        if(this.transform.childCount > 150)
        {
            Destroy(this.transform.GetChild(0).gameObject);
        }
    }
}
