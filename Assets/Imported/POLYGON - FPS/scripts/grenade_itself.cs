using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade_itself : MonoBehaviour
{

    public float grenade_power;

    public GameObject active_OBJS;



    public void Start()
    {
        active_OBJS = GameObject.Find("props_active");

        transform.localEulerAngles = new Vector3(transform.localEulerAngles.x-2, transform.localEulerAngles.y, transform.localEulerAngles.z);
    }

   


    public int dmg;
    public GameObject explosion;




    private void OnTriggerStay(Collider collider)
    {
        

        if (collider.tag != "Untagged")
        {



            foreach (GameObject gg in active_OBJS.GetComponent<find_destory_able_props>().objs_2)
            {
                if (gg != null)
                {

                    if (Vector3.Distance(transform.position, gg.transform.position) < 3)
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

                    if (Vector3.Distance(transform.position, gg.transform.position) < 3)
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

                    if (Vector3.Distance(transform.position, gg.transform.position) < 3)
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

                    if (Vector3.Distance(transform.position, gg.transform.position) < 3)
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

                    if (Vector3.Distance(transform.position, gg.transform.position) < 3)
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

                    if (Vector3.Distance(transform.position, gg.transform.position) < 3)
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



    public float fall_rotation;
    public float speed;


    public void Update()
    {
        transform.Translate(Vector3.forward * speed*Time.deltaTime);

        
            transform.Rotate(fall_rotation * speed * Time.deltaTime, 0, 0);
        
     
    }


}
