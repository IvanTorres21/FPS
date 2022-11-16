using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser_script : MonoBehaviour
{
    public GameObject point;
    public GameObject originShooting;

    public GameObject start_laser;
    public LayerMask mask;

    void Update()
    {

        

        RaycastHit hit;

        if (Physics.Raycast(originShooting.transform.position, originShooting.transform.forward ,out hit, Mathf.Infinity, ~mask))
        {
              point.transform.position = hit.point;
            point.transform.rotation =  Quaternion.LookRotation(hit.normal);

            start_laser.transform.position = hit.point;
            start_laser.transform.rotation = Quaternion.LookRotation(hit.normal);
        }
      


    }
}
