using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TextCore;

public class shoot_handle : MonoBehaviour
{
    public GameObject recyle_particles_performance;
    

    public void Start()
    {

        recyle_particles_performance = GameObject.FindGameObjectWithTag("rycle");
        get_cam();
    }


    public struct add_shoot
    {
       public Vector3 pos;
       public Vector3 rot;
       public int dmg;

        public add_shoot(Vector3 pos, Vector3 rot, int dmg)
        {
            this.pos = pos;
            this.rot = rot;
            this.dmg = dmg;
        }
    }

   
    private List<add_shoot> added_shoots = new List<add_shoot>();

    void Update()
    {
        foreach(add_shoot s in added_shoots)
        {
            
            shoot(s.pos, s.rot,s.dmg);
        }


        added_shoots.Clear();

    }


    public void register_shoot(Vector3 pos,Vector3 rot,int dmg)
    {
        added_shoots.Add(new add_shoot(pos, rot, dmg));
    }


    public LayerMask mask;

    public void shoot(Vector3 pos,Vector3 rot,int dmg)
    {




        RaycastHit hit;

        // shooting forward at postion and rotation Shoot_start_point + adding the Spread

        if (Physics.Raycast(pos, rot, out hit,Mathf.Infinity,~mask))
        {


            if (hit.collider.tag == "body")
            {



                // giving killer bunny damage
                hit.collider.gameObject.GetComponent<bunny_receive_dmg>().take_dmg(dmg);


                // spawning blood
                recyle_particles_performance.GetComponent<recyle_inst>().blood_particle_new(hit.point, (pos - hit.point));




            }





            // hitting petrol can for explosion
            if (hit.collider.tag == "petrol")
            {
                recyle_particles_performance.GetComponent<recyle_inst>().metall_particle_new(hit.point, (pos - hit.point));



                // blowing up the petrol can, to spawn much fireballs
                hit.collider.gameObject.GetComponent<petrol_can>().explosion_on();



            }






            // hitted collider with the name glass
            if (hit.collider.tag == "glass")
            {

                // glass particle spawning

                recyle_particles_performance.GetComponent<recyle_inst>().glass_particle_new(hit.point, (pos - hit.point));


                // destroying glass
                if (hit.collider.gameObject.GetComponent<destory_simple>())
                {
                    hit.collider.gameObject.GetComponent<destory_simple>().Destroyy();
                }

                // adding impact to the hitted object, if Rigidbody on it 
                if (hit.collider.GetComponent<Rigidbody>())
                {
                    hit.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, hit.point, 20);
                }




            }




            // activation of the automatic  metall door, if you shoot at the button
            if (hit.collider.tag == "lever")
            {
                hit.transform.GetComponent<lever>().Input();

            }






            // Extra glass, which is getting used by a wood door, with glass inside, because the lass collider overwrapes the wood collider at the door, gla
            if (hit.collider.tag == "wood_door_glass")
            {

                // spawining glass patricle
                recyle_particles_performance.GetComponent<recyle_inst>().glass_particle_new(hit.point, (pos - hit.point));

                // sending shoot on the glass from the door to the main door script to calcucalte, what's happening with the door next
                hit.collider.gameObject.GetComponent<to_parent_connect>().hitted_glass(dmg);

            }





            // not wood, for wood doors, which are able to break
            if (hit.collider.tag == "wood_door")
            {

                recyle_particles_performance.GetComponent<recyle_inst>().wood_particle_new(hit.point, (pos - hit.point));



                hit.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg / 10, hit.point, 10);


                hit.collider.gameObject.GetComponent<destroy_object>().Input_damage(dmg, false);





            }

            // not metall, for metall doors, which are able to break
            if (hit.collider.tag == "metall_door")
            {

                recyle_particles_performance.GetComponent<recyle_inst>().metall_particle_new(hit.point, (pos - hit.point));

                hit.transform.GetComponent<destroy_object>().Input_damage(dmg, false);
                hit.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg / 10, hit.point, 10);



            }
            if (hit.collider.tag == "metall")
            {
                recyle_particles_performance.GetComponent<recyle_inst>().metall_particle_new(hit.point, (pos - hit.point));


                // if metall without any script, is a object with a Rigidbody will it move
                if (hit.collider.GetComponent<Rigidbody>())
                {
                    hit.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg / 10, hit.point, 10);
                }


            }



            if (hit.collider.tag == "stone" || hit.collider.tag == "Untagged")
            {

                recyle_particles_performance.GetComponent<recyle_inst>().stone_particle_new(hit.point, (pos - hit.point));





            }

            // Dirt & Wood use the same particle, because the color is equal
            if (hit.collider.tag == "dirt")
            {

                recyle_particles_performance.GetComponent<recyle_inst>().dirt_particle_new(hit.point, (pos - hit.point));


            }

            if (hit.collider.tag == "wood")
            {

                recyle_particles_performance.GetComponent<recyle_inst>().wood_particle_new(hit.point, (pos - hit.point));


                // if the wood is as example a box, which is able to get destroyed
                if (hit.collider.gameObject.GetComponent<destory_simple>())
                {
                    hit.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, hit.point, 10);
                    hit.collider.gameObject.GetComponent<destory_simple>().Receive_DMG(dmg, false);
                }


            }






        }



    }


    

    public IList<GameObject> y_ = new List<GameObject>();


    private void LateUpdate()
    {
        

    }

    public Transform cam;
    public GameObject y;
    Vector3 yv;
    
    void get_cam()
    {

        

    }










}
