using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rocket_launcher : MonoBehaviour
{







   public void Start()
    {
        Shoot_start_point.transform.localPosition = Shoot_start_point_vector3;
        _3rd_view = player.GetComponent<polygon_fps_controller>()._3rd;
    }
    private void OnEnable()
    {
        in_reload = false;
        in_shoot = false;
    }




    public GameObject player;

    bool running;
    bool walking;
    bool duck_walk;
    bool reload;

    public bool _3rd_view;
    public Vector3 _3rd_view_cam;

    void Update()
    {
        Input_Status();

        running = player.GetComponent<polygon_fps_controller>().running;
        walking = player.GetComponent<polygon_fps_controller>().walking;
        duck_walk = player.GetComponent<polygon_fps_controller>().duck_walk;
        reload = player.GetComponent<polygon_fps_controller>().reload;
        cam_toggled = player.GetComponent<polygon_fps_controller>().cam_toggled;

     

      








        if (button_shoot && !in_shoot && magazine_current > 0 && !in_reload && !running)
        {
            in_shoot = true;
            finished_shoot = false;
            shooting = StartCoroutine(shoot());


        }
        if (!button_shoot && finished_shoot)
        {
            in_shoot = false;

        }

        // aim
        if (button_aim && !button_shoot && !in_reload)
        {
            ani.SetInteger("rocket_launcher", 0);
         
        }
        // idle
        if (!button_aim && !button_shoot && !in_reload)
        {
            ani.SetInteger("rocket_launcher", 0);
           
        }


        // As the flamethrower hasn't the rocketlauncher a aim position, expecting some cam movment

        if (walking && !in_reload)
        {

            if (!button_aim)
            {
                //  walk
                ani.SetInteger("rocket_launcher", 2);

                // slow down duck walk
                if (duck_walk)
                {
                    ani.SetFloat("rocket_launcher", 0.5f);
                }
                else
                {
                    ani.SetFloat("rocket_launcher", 2);
                }
            }

            if (button_aim)
            {
                //  walk
                ani.SetInteger("rocket_launcher", 2);

                if (duck_walk)
                {
                    ani.SetFloat("rocket_launcher", 0.5f);
                }
                else
                {
                    ani.SetFloat("rocket_launcher", 2);
                }
            }
        }


        // run 
        if (running && !in_reload)
        {

            ani.SetInteger("rocket_launcher", 2);

        }


        // aim shoot

        if (button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("rocket_launcher", 4);

            
        }

        // idle shoot

        if (!button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("rocket_launcher", 4);

          
        }


        //reloading
        if (reload && !in_reload && stored_bullets > 0 && magazine_current != magazine_max)
        {
            reloading = StartCoroutine(reload_start());

           
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
    public GameObject rocket;


  



    bool in_shoot;
    Coroutine shooting;
    public bool full_auto;
    public float firerate;
    bool finished_shoot;







    public Vector3 Shoot_start_point_vector3;

    public IEnumerator shoot()
    {

        yield return new WaitForSeconds(0);



        default_rocket.SetActive(false);

          magazine_current -= 1;



        // spawning rocket
        Instantiate(rocket, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
       






        yield return new WaitForSeconds(firerate);



        if (magazine_current > 0 && full_auto && button_shoot)
        {
            StopCoroutine(shoot());
            shooting = StartCoroutine(shoot());
        }

        if (!full_auto)
        {
            finished_shoot = true;
            StopCoroutine(shoot());
        }
        if (!button_shoot)
        {
            finished_shoot = true;
            StopCoroutine(shoot());
        }


    }



    public int magazine_max;
    public int magazine_current;
    public int stored_bullets;

    public AudioClip reload_sound;
    public AudioClip shoot_sound;

    Coroutine reloading;
    bool in_reload;
    bool finished_reload_in_reload;

    public GameObject Clip_on_point;
    public GameObject default_rocket;
    public IEnumerator reload_start()
    {
        // blocking other key input to interprut the reload and blocking shoot with turning on in_reload and finished_reload_in_reload

        in_reload = true;
        finished_reload_in_reload = false;


      
        //  reload
        ani.SetInteger("rocket_launcher", 6);

        // putting aduioclip on new spawned empty object and transform parent it to the point Shoot_start_point for a static sound
        GameObject g = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
        g.GetComponent<AudioSource>().clip = reload_sound;
        g.GetComponent<AudioSource>().maxDistance = 15;
        g.GetComponent<AudioSource>().Play();
        g.transform.parent = Shoot_start_point.transform;

        // turing on default rocket to appear it if reloading
        yield return new WaitForSeconds(0.583f);

        default_rocket.SetActive(true);

        // rest reload time
        yield return new WaitForSeconds(1.041f);

        // if there aren't enough bullet to fill the complet magazine, different reloading handle for bullets
        if (stored_bullets < magazine_max && !finished_reload_in_reload)
        {
            finished_reload_in_reload = true;
            stored_bullets += magazine_current;
            magazine_current = 0;
            magazine_current = stored_bullets;
            stored_bullets = 0;
        }
        // enough bullets in stored bullets just to fill the full magazine and if the bullets released, will the shooting get unlocked with finished_reload_in_reload

        if (stored_bullets > magazine_max || stored_bullets == magazine_max && !finished_reload_in_reload)
        {
            finished_reload_in_reload = true;
            stored_bullets += magazine_current;
            magazine_current = 0;
            magazine_current = magazine_max;
            stored_bullets -= magazine_max;
        }

        finished_shoot = true;
        in_reload = false;
        StopCoroutine(reload_start());

    }



    public GameObject Cam;
    public Animator ani;

    public Vector3 idle_cam;
    public Vector3 aim_cam;
    public Vector3 run_cam;




    public void cam_equipment()
    {

    
        // 3rd view
        if (_3rd_view)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, _3rd_view_cam, 15 * Time.deltaTime);

            return;
        }



        // different cam positions, idle, aim, 3rd

        if (in_reload)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, idle_cam, 15 * Time.deltaTime);
        }
        if (!button_aim && !running && !in_reload) //idle
        {

            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, idle_cam, 15 * Time.deltaTime);


        }
        if (button_aim && !running && !in_reload) //aim
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, aim_cam, 15 * Time.deltaTime);

        }
        if (running && !in_reload)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, run_cam, 15 * Time.deltaTime);
        }








    }

 
    public void turn_off_weapon()
    {
        // reset all, also the animation to -1, that none animations from an different gun, runs into the animation/with the current one, or the result would be awful and not wished

        ani.SetInteger("rocket_launcher", -1);
  


    }




















}
