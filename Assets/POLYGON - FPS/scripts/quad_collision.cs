using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quad_collision : MonoBehaviour
{
    public int dmg;




    // reusing particle and not spawning them again -> Performance

    public GameObject recyle_particles_performance;

    public int which_speed_Collision;

    void Start()
    {
        recyle_particles_performance = GameObject.FindGameObjectWithTag("rycle");
    }


    public GameObject my_quad;

    public GameObject my_8x8;

    public void OnCollisionEnter(Collision collision)
    {



        if (my_quad != null)
        {
            if (collision.collider.tag == "body" && my_quad.GetComponent<quad_controll>().current_speeed > which_speed_Collision)
            {





                if (collision.collider.gameObject.GetComponent<bunny_receive_dmg>().is_head)
                {
                    // giving killer bunny damage head x 4
                    collision.collider.gameObject.GetComponent<bunny_receive_dmg>().take_dmg(dmg * (int)(my_quad.GetComponent<quad_controll>().current_speeed / 10f));
                }
                else
                {
                    // giving killer bunny damage body
                    collision.collider.gameObject.GetComponent<bunny_receive_dmg>().take_dmg(dmg * (int)(my_quad.GetComponent<quad_controll>().current_speeed / 10f));
                }



                // spawning blood
                recyle_particles_performance.GetComponent<recyle_inst>().blood_particle_new(collision.contacts[0].point, transform.position);





            }
        }

        if (my_8x8 != null)
        {
            if (collision.collider.tag == "body" && my_8x8.GetComponent<controll_8x8>().current_speeed > which_speed_Collision)
            {





                if (collision.collider.gameObject.GetComponent<bunny_receive_dmg>().is_head)
                {
                    // giving killer bunny damage head x 4
                    collision.collider.gameObject.GetComponent<bunny_receive_dmg>().take_dmg(dmg * (int)(my_8x8.GetComponent<controll_8x8>().current_speeed / 10f));
                }
                else
                {
                    // giving killer bunny damage body
                    collision.collider.gameObject.GetComponent<bunny_receive_dmg>().take_dmg(dmg * (int)(my_8x8.GetComponent<controll_8x8>().current_speeed / 10f));
                }



                // spawning blood
                recyle_particles_performance.GetComponent<recyle_inst>().blood_particle_new(collision.contacts[0].point, transform.position);





            }
        }







        // hitting petrol can for explosion
        if (collision.collider.tag == "petrol")
        {
            // spawning blood
            recyle_particles_performance.GetComponent<recyle_inst>().metall_particle_new(collision.contacts[0].point, transform.position);

            // blowing up the petrol can, to spawn much fireballs
            collision.collider.gameObject.GetComponent<petrol_can>().explosion_on();






            // if metall without any script, is a object with a Rigidbody will it move
            if (collision.collider.GetComponent<Rigidbody>())
            {
                collision.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, collision.contacts[0].point, 10);
            }


        }






        // hitted collider with the name glass
        if (collision.collider.tag == "glass")
        {








            // glass particle
            // spawning blood
            recyle_particles_performance.GetComponent<recyle_inst>().glass_particle_new(collision.contacts[0].point, transform.position);


            // destroying glass
            if (collision.collider.gameObject.GetComponent<destory_simple>())
            {
                collision.collider.gameObject.GetComponent<destory_simple>().Destroyy();
            }

            // adding impact to the hitted object, if Rigidbody on it 
            if (collision.collider.GetComponent<Rigidbody>())
            {
                collision.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, collision.contacts[0].point, 20);
            }





        }




        // activation of the automatic  metall door, if you shoot at the button
        if (collision.collider.tag == "lever")
        {
            collision.collider.transform.GetComponent<lever>().Input();

        }






        // Extra glass, which is getting used by a wood door, with glass inside, because the lass collider overwrapes the wood collider at the door, gla
        if (collision.collider.tag == "wood_door_glass")
        {

            // spawning glass
            recyle_particles_performance.GetComponent<recyle_inst>().glass_particle_new(collision.contacts[0].point, transform.position);

            // sending shoot on the glass from the door to the main door script to calcucalte, what's happening with the door next
            collision.collider.gameObject.GetComponent<to_parent_connect>().hitted_glass(dmg);







        }





        // not wood, for wood doors, which are able to break
        if (collision.collider.tag == "wood_door")
        {

            // spawning wood
            recyle_particles_performance.GetComponent<recyle_inst>().wood_particle_new(collision.contacts[0].point, transform.position);

            collision.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, collision.contacts[0].point, 10);

            collision.collider.gameObject.GetComponent<destroy_object>().Input_damage(dmg, false);





        }

        // not metall, for metall doors, which are able to break
        if (collision.collider.tag == "metall_door")
        {

            // spawning blood
            recyle_particles_performance.GetComponent<recyle_inst>().metall_particle_new(collision.contacts[0].point, transform.position);

            collision.collider.transform.GetComponent<destroy_object>().Input_damage(dmg, false);
            collision.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, collision.contacts[0].point, 10);




        }
        if (collision.collider.tag == "metall")
        {
            // spawning blood
            recyle_particles_performance.GetComponent<recyle_inst>().metall_particle_new(collision.contacts[0].point, transform.position);





            // if metall without any script, is a object with a Rigidbody will it move
            if (collision.collider.GetComponent<Rigidbody>())
            {
                collision.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, collision.contacts[0].point, 10);
            }

        }
        if (collision.collider.tag == "stone")
        {
            // spawning blood
            recyle_particles_performance.GetComponent<recyle_inst>().stone_particle_new(collision.contacts[0].point, transform.position);


        }

        // Dirt & Wood have the same color so the same particles gettign use for it
        if (collision.collider.tag == "dirt")
        {

            // spawning blood
            recyle_particles_performance.GetComponent<recyle_inst>().wood_particle_new(collision.contacts[0].point, transform.position);


        }

        if (collision.collider.tag == "wood")
        {

            // spawning blood
            recyle_particles_performance.GetComponent<recyle_inst>().wood_particle_new(collision.contacts[0].point, transform.position);

            // if the wood is as example a box, which is able to get destroyed
            if (collision.collider.gameObject.GetComponent<destory_simple>())
            {
                collision.collider.GetComponent<Rigidbody>().AddExplosionForce(dmg, collision.contacts[0].point, 10);
                collision.collider.gameObject.GetComponent<destory_simple>().Receive_DMG(dmg, false);
            }


        }







    }

}
