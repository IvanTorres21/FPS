using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flame_script : MonoBehaviour
{

    public int dmg;
    private void OnCollisionEnter(Collision collision)
    {

        if(collision.collider.tag == "body")
        {



            collision.collider.gameObject.GetComponent<bunny_receive_dmg>().Burn_me();
            collision.collider.gameObject.GetComponent<bunny_receive_dmg>().take_dmg(100);
        }






        if (collision.collider.tag == "wood")
        {

            if (collision.collider.gameObject.GetComponent<destory_simple>())
            {
   
                collision.collider.gameObject.GetComponent<destory_simple>().Receive_DMG(dmg, true);
                Destroy(gameObject);
            }

        }
        if (collision.collider.tag == "petrol")
        {

           

                collision.collider.gameObject.GetComponent<petrol_can>().explosion_on();
                Destroy(gameObject);
            

        }





        if (collision.collider.tag == "glass")
        {

          

            if (collision.collider.gameObject.GetComponent<destory_simple>())
            {
                collision.collider.gameObject.GetComponent<destory_simple>().Destroyy();
            }

         


        }




        if (collision.collider.tag == "wood_door")
        {



            collision.collider.gameObject.GetComponent<destroy_object>().Input_damage(300, false);





        }





        if (collision.collider.tag == "wood_door_glass")
        {
            Debug.Log("hitted wood glass");

            collision.collider.gameObject.GetComponent<to_parent_connect>().hitted_glass(700);


        }







        if ( collision.collider.tag != "fireball")
        {
            if (GetComponent<Rigidbody>())
            {
                GetComponent<Rigidbody>().isKinematic = true;
            }
        }

      








    }
}
