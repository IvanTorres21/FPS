using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blast_set : MonoBehaviour
{





   public void Start()
    {
        _3rd_view = player.GetComponent<polygon_fps_controller>()._3rd;
    }




  
    public GameObject player;

    bool running;
    bool walking;
    bool duck_walk;


    public bool _3rd_view;
    public Vector3 _3rd_view_cam;

    void Update()
    {
        Input_Status();

        running = player.GetComponent<polygon_fps_controller>().running;
        walking = player.GetComponent<polygon_fps_controller>().walking;
        duck_walk = player.GetComponent<polygon_fps_controller>().duck_walk;
        cam_toggled = player.GetComponent<polygon_fps_controller>().cam_toggled;






        if (button_shoot && !in_shoot && magazine_current > 0 && !running)
        {
            in_shoot = true;
            finished_shoot = false;
            shooting = StartCoroutine(shoot());

        }

        if (!button_shoot && finished_shoot)
        {
            in_shoot = false;

        }

        // idle
        if (!button_shoot && !in_shoot)
        {
            ani.SetInteger("blast_set", 0);            
        }
       


        if (walking)
        {

                //  walk
                ani.SetInteger("blast_set", 1);

                if (duck_walk)
                {
                    ani.SetFloat("weapon_speed", 0.5f);
                }
                else
                {
                    ani.SetFloat("weapon_speed", 1);
                }
            
        }

        // button to blowing up the package of blast
        if(button_aim)
        {
            foreach(GameObject g in Throwed_blast_sets)
            {
                if (g != null)
                {
                    g.GetComponent<blast_set_itself>().blowing_up();
                }
            }
        }


        // run 
        if (running)
        {

            ani.SetInteger("blast_set", 2);

        }


        // throw

        if (button_shoot && !running && magazine_current > 0)
        {
            ani.SetInteger("blast_set", 3);
        }

 




        cam_equipment();
    }


    public bool button_shoot;
    public bool button_aim;
    public bool key_reload;
    public bool cam_toggled;


    public void Input_Status()
    {
        if (Input.GetButton("Fire1"))
        {
            button_shoot = true;
        }
        else
        {
            button_shoot = false;
        }

        if (cam_toggled)
        {
            _3rd_view = true;
            player.GetComponent<polygon_fps_controller>()._3rd = false;
            player.GetComponent<polygon_fps_controller>().head_3rd_status();
        }
        else
        {
            _3rd_view = false;
            player.GetComponent<polygon_fps_controller>()._3rd = true;
            player.GetComponent<polygon_fps_controller>().head_3rd_status();
        }


        if (Input.GetButton("Fire2"))
        {
            button_aim = true;
        }
        else
        {
            button_aim = false;
        }


        if (Input.GetKey(KeyCode.R))
        {
            key_reload = true;
        }
        else
        {
            key_reload = false;
        }

        if (_3rd_view)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, _3rd_view_cam, 15 * Time.deltaTime);

        }
    }





    public GameObject Shoot_start_point;
    public GameObject blast_package;


    float Push_bolt;



    bool in_shoot;
    Coroutine shooting;
    public bool full_auto;
    bool finished_shoot;



    public AudioClip blast_set_sound;


    public GameObject blast_set_mesh;




    public List<GameObject> Throwed_blast_sets = new List<GameObject>();

    public IEnumerator shoot()
    {

        yield return new WaitForSeconds(0.458f);

        blast_set_mesh.SetActive(false);

        magazine_current -= 1;


   


        // spawning fireball, which has is own sccript to dmage things 
        GameObject spawne_blast = Instantiate(blast_package, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
        Throwed_blast_sets.Add(spawne_blast);
        spawne_blast.GetComponent<Rigidbody>().AddForce((Shoot_start_point.transform.forward * 7 ), ForceMode.Impulse);

        AudioSource.PlayClipAtPoint(blast_set_sound, Shoot_start_point.transform.position);

       

        if(magazine_current > 0)
        {
            blast_set_mesh.SetActive(true);
        }


        if (!full_auto)
        {
            finished_shoot = true;
            StopCoroutine(shoot());
        }
       


    }



    
    public int magazine_current;






    public GameObject Cam;
    public Animator ani;

    public Vector3 idle_cam;
    public Vector3 aim_cam;
    public Vector3 run_cam;




    public void cam_equipment()
    {

   

        if (_3rd_view)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, _3rd_view_cam, 15 * Time.deltaTime);

            return;
        }



        // different cam positions, idle, aim, 3rd

     
        if (!button_aim && !running) //idle
        {

            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, idle_cam, 15 * Time.deltaTime);


        }
        if (button_aim && !running) //aim
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, aim_cam, 15 * Time.deltaTime);

        }
        if (running)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, run_cam, 15 * Time.deltaTime);
        }








    }

    public void turn_off_weapon()
    {
        // reset all, also the animation to -1, that none animations from an different gun, runs into the animation/with the current one, or the result would be awful and not wished

        ani.SetInteger("blast_set", -1);
   


    }








}
