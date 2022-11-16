using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast_set_itself : MonoBehaviour
{

    public GameObject active_OBJS;

    public bool timer;
    public void Start()
    {
        active_OBJS = GameObject.Find("props_active");

        if(timer)
        {
            StartCoroutine(blow_up_timer());
        }



    }


    IEnumerator blow_up_timer()
    {
        yield return new WaitForSeconds(3);


       blowing_up();



    }





    public int dmg;
    public GameObject explosion;

  
    

    public void blowing_up() 
    {

            foreach (GameObject gg in active_OBJS.GetComponent<find_destory_able_props>().objs_2)
            {
                if (gg != null)
                {

                    if (Vector3.Distance(transform.position, gg.transform.position) < 5)
                    {


                        if (gg.GetComponent<destroy_object>())
                        {
                            gg.GetComponent<destroy_object>().Input_damage(dmg, false);
                        }

                        gg.GetComponent<Rigidbody>().AddExplosionForce(2500, transform.position, 4);

                    }
                }


            }
            foreach (GameObject gg in active_OBJS.GetComponent<find_destory_able_props>().objs_3)
            {
                if (gg != null)
                {

                    if (Vector3.Distance(transform.position, gg.transform.position) < 5)
                    {


                        if (gg.GetComponent<destroy_object>())
                        {
                            gg.GetComponent<destroy_object>().Input_damage(dmg, false);
                        }

                        gg.GetComponent<Rigidbody>().AddExplosionForce(2500, transform.position, 4);

                    }

                }
            }
            foreach (GameObject gg in active_OBJS.GetComponent<find_destory_able_props>().objs_4)
            {

                if (gg != null)
                {

                    if (Vector3.Distance(transform.position, gg.transform.position) < 5)
                    {


                        if (gg.GetComponent<destory_simple>())
                        {
                            gg.GetComponent<destory_simple>().Destroyy();
                        }

                        gg.AddComponent<Rigidbody>();
                        gg.GetComponent<Rigidbody>().AddExplosionForce(2500, transform.position, 4);

                    }


                }
            }
            foreach (GameObject gg in active_OBJS.GetComponent<find_destory_able_props>().objs_5)
            {

                if (gg != null)
                {

                    if (Vector3.Distance(transform.position, gg.transform.position) < 5)
                    {

                        if (gg.GetComponent<destory_simple>())
                        {
                            if (gg.GetComponent<destory_simple>())
                            {
                                gg.GetComponent<destory_simple>().Destroyy();
                            }

                            if (gg.GetComponent<Rigidbody>())
                            {
                                gg.GetComponent<Rigidbody>().AddExplosionForce(2500, transform.position, 3);
                            }
                        }
                    }
                }

            }
            foreach (GameObject gg in active_OBJS.GetComponent<find_destory_able_props>().objs_6)
            {
                if (gg != null)
                {

                    if (Vector3.Distance(transform.position, gg.transform.position) < 5)
                    {


                        if (gg.GetComponent<petrol_can>())
                        {
                            gg.GetComponent<petrol_can>().explosion_on();
                        }



                    }

                }
            }

            foreach (Transform gg in active_OBJS.GetComponent<find_destory_able_props>().objs_7)
            {
                if (gg != null)
                {

                    if (Vector3.Distance(transform.position, gg.transform.position) < 5)
                    {


                        if (gg.GetComponent<bunny_receive_dmg>())
                        {
                            gg.GetComponent<bunny_receive_dmg>().take_dmg(dmg);
                        }



                    }

                }
            }


    


            Instantiate(explosion, transform.position, transform.rotation);
            Destroy(gameObject);
    }
}











