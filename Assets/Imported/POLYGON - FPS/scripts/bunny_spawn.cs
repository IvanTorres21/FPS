using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bunny_spawn : MonoBehaviour
{




    public bool start_bunny_spawn;

    public GameObject killer_bunny;

    public int spawn_ticks;
    public int spawn_ticks_current;
    bool in_spawn;




    void FixedUpdate()
    {





        if (Input.GetKeyDown(KeyCode.T))
        {

            int Child_count = transform.childCount;


            Instantiate(killer_bunny, transform.GetChild(UnityEngine.Random.Range(0, Child_count)).position, transform.rotation);
            Instantiate(killer_bunny, transform.GetChild(UnityEngine.Random.Range(0, Child_count)).position, transform.rotation);
            Instantiate(killer_bunny, transform.GetChild(UnityEngine.Random.Range(0, Child_count)).position, transform.rotation);


        }





        

    }
}
