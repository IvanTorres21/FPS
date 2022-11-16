using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade_launcher : MonoBehaviour
{




    float Power_bolt;
    public GameObject player;

    bool running;
    bool walking;
    bool walking_side;
    bool duck_walk;
    bool reload;

    public bool _3rd_view;
    public Vector3 _3rd_view_cam;

    public void Start()
    {
       
        Shoot_start_point.transform.localPosition = shoot_origin;
        _3rd_view = player.GetComponent<polygon_fps_controller>()._3rd;
    }

    private void OnEnable()
    {
        in_reload = false;
        in_shoot = false;
    }

    bool in_checking_colled_down;

    IEnumerator shoot_cool_down()
    {
        yield return new WaitForSeconds(0);

    
        yield return new WaitForSeconds(0.2f);

        in_shoot = false;
        in_checking_colled_down = false;
    }


    void Update()
    {
        // running key input checking
        Input_Status();

        // getting stats from the main player, if walking as example, that we don't need to check here, if the player is walking, just need to reading out the main player
        running = player.GetComponent<polygon_fps_controller>().running;
        walking = player.GetComponent<polygon_fps_controller>().walking;
        walking_side = player.GetComponent<polygon_fps_controller>().walking_side;
        duck_walk = player.GetComponent<polygon_fps_controller>().duck_walk;
        reload = player.GetComponent<polygon_fps_controller>().reload;
        cam_toggled = player.GetComponent<polygon_fps_controller>().cam_toggled;

        // Push force against shoot animation, force get added, if shoot to play the animation forward


        // each shoot add 1 to power_bolt, which is the animatin position for the shooting, shooting means
        // that the gun animation play forward to the maximal determined point and this -0.1f presses it back
        // to the idle output point
        if (Power_bolt > -1)
        {
            Power_bolt -= 0.06f;

        }
        // getting sure, that the backpress playing of the animation/ shooting not getting faster than -1
        if (Power_bolt < -1)
        {
            Power_bolt = -1;
        }

        // changing the gun animation playing time  ->  force getting added at shooting and plays until the maximal 
        //recoil and pressed down by -0.1 by each process of the update function

        ani.SetFloat("Power_bolt", Power_bolt);







        // In shooting with a magazine upper than 0 bullets  / not able while reloading and running
        if (button_shoot && !in_shoot && magazine_current > 0 && !in_reload && !running)
        {
            in_shoot = true;
            finished_shoot = false;
            shooting = StartCoroutine(shoot());


        }
        // not in shooting,   recovering current_spread
        if (!button_shoot && finished_shoot)
        {
            in_shoot = false;
        }


        if (button_aim && !button_shoot && !in_reload && !in_shoot)
        {
            // aim animation / animator
            ani.SetInteger("grenade_launcher", 1);
        }
        if (!button_aim && !button_shoot && !in_reload && !in_shoot)
        {
            // idle animation / animator
            ani.SetInteger("grenade_launcher", 0);
        }

        // walking states /  not accessable while reloading
        if (walking && !in_reload)
        {
            if (!button_aim)
            {
                // idle with walking
                ani.SetInteger("grenade_launcher", 2);

                // if walking in ducking, will the speed for the animation decrease to 50 %
                if (duck_walk)
                {
                    ani.SetFloat("weapon_speed", 0.5f);
                }
                else
                {
                    ani.SetFloat("weapon_speed", 1);
                }
                if (walking_side)
                {
                    ani.SetFloat("weapon_speed", 0.8f);
                }
            }

            if (button_aim)
            {
                // aim with walking
                ani.SetInteger("grenade_launcher", 3);

                // if walking in ducking, will the speed for the animation decrease to 50 %
                if (duck_walk)
                {
                    ani.SetFloat("weapon_speed", 0.5f);
                }
                else
                {
                    ani.SetFloat("weapon_speed", 1);
                }
            }
        }


        // running animation at animator
        if (running && !in_reload)
        {

            ani.SetInteger("grenade_launcher", 6);



        }


        // aim shoot animation at animator   // blocked while reloading and with a empty magazine
        if (button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("grenade_launcher", 5);
        }
        // idle shoot animation at animator   // blocked while reloading and with a empty magazine
        if (!button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("grenade_launcher", 4);
        }

        // execute reloading
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

        // Extra void to get the controll clear and to make it more clean and comfortable to work with


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

        // moving cam to 3rd position

        if (_3rd_view)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, _3rd_view_cam, 15 * Time.deltaTime);

        }
    }





    public GameObject Shoot_start_point;
    public GameObject muzzle;


    public float Push_bolt;



    bool in_shoot;
    Coroutine shooting;
    public bool full_auto;
    public float firerate;
    bool finished_shoot;


    public AudioClip shoot_sound;




    public GameObject _40mm;


   

    public IEnumerator shoot()
    {

        yield return new WaitForSeconds(0);



       




        // The Shoot animation isn't looped, if you shoot will a positive time get setted on the animtor/animation/shooting -> Power_bolt
        Power_bolt = 1;



        // starting muzzle for shooting
        GameObject spawned_muzzle = Instantiate(muzzle, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
        spawned_muzzle.GetComponent<muzzle_flash>().origin = Shoot_start_point;

        // spawning grenade
        GameObject spawne_40mm= Instantiate(_40mm, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
       

        // adding shoot sound

        GameObject g = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
            g.GetComponent<AudioSource>().clip = shoot_sound;
            g.GetComponent<AudioSource>().maxDistance = 100;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = Shoot_start_point.transform;
  


       

        // turning delay for shoot in semi shoot mode off for bnetter experience
        if (full_auto)
        {
            yield return new WaitForSeconds(firerate);
        }


        // minus for the magazine of the weapon here
        magazine_current -= 1;


        // check if magazine has a bullet left to repeat the shooting and if the trigger is pressed down and if fullauto is enabled
        if (magazine_current > 0 && full_auto && button_shoot)
        {
            StopCoroutine(shoot());
            shooting = StartCoroutine(shoot());
        }

        // break the shoot, because it is setted on semiauto
        if (!full_auto)
        {
            finished_shoot = true;
            StopCoroutine(shoot());
        }
        // no shoot button pressed
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


    Coroutine reloading;
    bool in_reload;
    float reload_time;
    bool finished_reload_in_reload;

    public GameObject Clip_on_point;


    public GameObject grenade_1;
    public GameObject grenade_2;
    public GameObject grenade_3;

    public GameObject grenade_4;
    public GameObject grenade_5;
    public GameObject grenade_6;


    public GameObject grenade_1_head;
    public GameObject grenade_2_head;
    public GameObject grenade_3_head;

    public GameObject grenade_4_head;
    public GameObject grenade_5_head;
    public GameObject grenade_6_head;



    public IEnumerator reload_start()
    {

        // blocking other key input to interprut the reload and blocking shoot with turning on in_reload and finished_reload_in_reload
        in_reload = true;
        finished_reload_in_reload = false;


        // turning off all bullet heads in magazine drum, to simulate empty
        grenade_1_head.SetActive(false);
        grenade_2_head.SetActive(false);
        grenade_3_head.SetActive(false);

        grenade_4_head.SetActive(false);
        grenade_5_head.SetActive(false);
        grenade_6_head.SetActive(false);

        // checking, how much bullets aren't shoot to turning on the heads of the 40mm

        if (magazine_current > 0)
        {
            grenade_1_head.SetActive(true);
        }
        if (magazine_current > 1)
        {
            grenade_2_head.SetActive(true);
        }
        if (magazine_current > 2)
        {
            grenade_3_head.SetActive(true);
        }
        if (magazine_current > 3)
        {
            grenade_4_head.SetActive(true);
        }
        if (magazine_current > 4)
        {
            grenade_5_head.SetActive(true);
        }
        if (magazine_current > 5)
        {
            grenade_6_head.SetActive(true);
        }






        // reload animation
        reload_time = 4.499f;
            ani.SetInteger("grenade_launcher", 7); //  reload    - putting aduioclip on new spawned empty object and transform parent it to the point Shoot_start_point for a static sound

            GameObject g = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
        g.GetComponent<timer_destroy>().ticks = 500;
            g.GetComponent<AudioSource>().clip = reload_sound;
            g.GetComponent<AudioSource>().maxDistance = 15;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = Shoot_start_point.transform;
      

        // reload time over
        yield return new WaitForSeconds(reload_time);


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
        // releasing weapon for the update function, to get shooted again
        finished_shoot = true;
        in_reload = false;
        // stopping all runs for reloading
        StopCoroutine(reload_start());

    }



    public GameObject Cam;
    public GameObject Grenade_launcher_scope_camera;
    public Animator ani;


    // camera positions for different scopes and states as 3rd
    public Vector3 idle_cam;
    public Vector3 aim_cam;
    public Vector3 run_cam;




    public Vector3 shoot_origin;

    public void cam_equipment()
    {

        // changing cam postion for different situation as 3rd and running and different little postion at different scopes


        Grenade_launcher_scope_camera.SetActive(true);

        if (_3rd_view)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, _3rd_view_cam, 15 * Time.deltaTime);

            return;
        }




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

        ani.SetInteger("grenade_launcher", -1);
        Grenade_launcher_scope_camera.SetActive(false);




    }





}
