using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clusterShotgun : MonoBehaviour
{





    public GameObject bullet_mesh;
    public GameObject shoot_handle;
    public GameObject recyle_particles_performance;

    public void Start()
    {
        recyle_particles_performance = GameObject.FindGameObjectWithTag("rycle");
        shoot_handle = player.GetComponent<polygon_fps_controller>().shoot_handle;
        // if starting with this gun, getting the equipment updated
        change_equipment();
        bullet_mesh.SetActive(false);
        _3rd_view = player.GetComponent<polygon_fps_controller>()._3rd;
    }

    private void OnEnable()
    {
        in_reload = false;
        in_shoot = false;
    }



    public

    float Power_bolt;
    public GameObject player;

    bool running;
    bool walking;
    bool walking_side;
    bool duck_walk;
    bool reload;

    public bool _3rd_view;
    public Vector3 _3rd_view_cam;
    

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
            Power_bolt -= 0.1f;

        }
        // getting sure, that the backpress playing of the animation/ shooting not getting faster than -1
        if (Power_bolt < -1)
        {
            Power_bolt = -1;
        }

        // changing the gun animation playing time  ->  force getting added at shooting and plays until the maximal 
        //recoil and pressed down by -0.1 by each process of the update function

        ani.SetFloat("Power_bolt", Power_bolt);





       //  button_aim = true;

        // In shooting with a magazine upper than 0 bullets  / not able while reloading and running
        if (button_shoot && !in_shoot && magazine_current > 0 && !in_reload && !running && !in_shoot && cool_down_shoot)
        {
            in_shoot = true;
            cool_down_shoot = false;
            shooting = StartCoroutine(shoot());


        }
        if(!button_shoot)
        {
            cool_down_shoot = true;
        }


        if (button_aim && !button_shoot && !in_reload && !in_shoot)
        {
            // aim animation / animator
            ani.SetInteger("clustershotgun", 4);
        }
        if (!button_aim && !button_shoot && !in_reload && !in_shoot)
        {
            // idle animation / animator
            ani.SetInteger("clustershotgun", 0);
        }

        // staying in aim position  :: for adjustments


        // walking states /  not accessable while reloading
        if (walking && !in_reload && !in_shoot)
        {
            if (!button_aim)
            {
                // idle with walking
                ani.SetInteger("clustershotgun", 2);

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
                ani.SetInteger("clustershotgun", 6);

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
        if (running && !in_reload && !in_shoot)
        {

            ani.SetInteger("clustershotgun", 8);


        }


        // aim shoot animation at animator   // blocked while reloading and with a empty magazine
        if (button_aim && button_shoot && !running && !in_reload && magazine_current > 0 && !in_shoot)
        {
            ani.SetInteger("clustershotgun", 7);
        }
        // idle shoot animation at animator   // blocked while reloading and with a empty magazine
        if (!button_aim && button_shoot && !running && !in_reload && magazine_current > 0 && !in_shoot)
        {
            ani.SetInteger("clustershotgun", 1);
        }

        // execute reloading shell
        if (reload && !in_reload && stored_bullets > 0 && magazine_current != magazine_max && !in_shoot) 
        {
 
            reloading = StartCoroutine(reload_start());

        }

       
       // ani.SetInteger("buzzsub", 4);

        cam_equipment();
    }


    bool button_shoot;
    bool button_aim;
    bool key_reload;
    bool cam_toggled;


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


    float Push_bolt;



    bool in_shoot;
    Coroutine shooting;
    public bool full_auto;
    public float firerate;
    bool finished_shoot;


    public AudioClip shoot_sound;






    public int Joule;




    public float vertical_force;
    public float horizontal_force;

    public float spread_height;
    public float current_spread;


    public int flesh_count;
    bool bullet_stopped;


    public AudioClip pump_sound;
    bool cool_down_shoot;

    public IEnumerator shoot()
    {

        yield return new WaitForSeconds(0);


        // shoot animation
        if (button_aim)
        {
            // aim animation / animator
            ani.SetInteger("clustershotgun", 7);
        }
        if (!button_aim)
        {
            // idle animation / animator
            ani.SetInteger("clustershotgun", 1);
        }





        // The bullet can pass unlimted glass and a serveral amount of flesh and will stoped by hard ground as wood and stone  /  Here it gets refreshed

        bullet_stopped = false;




        // The Shoot animation isn't looped, if you shoot will a positive time get setted on the animtor/animation/shooting -> Power_bolt
        Power_bolt = 1;


        // starting muzzle for shooting
        GameObject spawned_muzzle = Instantiate(muzzle, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
        spawned_muzzle.GetComponent<muzzle_flash>().origin = Shoot_start_point;


        // adding suppressed shoot sound or a normal one

        GameObject bg = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
        bg.GetComponent<AudioSource>().clip = shoot_sound;
        bg.GetComponent<AudioSource>().maxDistance = 50;
        bg.GetComponent<AudioSource>().Play();
        bg.transform.parent = Shoot_start_point.transform;



        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();

        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();
        shoot_raycast();



     
  


        // addind recoil on aimming -> movement of Polygon_fps_controller 

        float add_ver_force = UnityEngine.Random.Range(0, vertical_force);
        float add_hor_force = UnityEngine.Random.Range(-horizontal_force, horizontal_force);


        player.GetComponent<polygon_fps_controller>().vertical_float_spread = -add_ver_force;
        player.GetComponent<polygon_fps_controller>().horizontal_float_spread = add_hor_force;

        // minus for the magazine of the weapon here
        magazine_current -= 1;
        // driopping bullet shell
       

        yield return new WaitForSeconds(0.06f);

        // pump sound effect

        GameObject g2 = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
        g2.GetComponent<AudioSource>().clip = pump_sound;
        g2.GetComponent<AudioSource>().maxDistance = 10;
        g2.GetComponent<AudioSource>().Play();
        g2.transform.parent = Shoot_start_point.transform;
        bullet_drop();
        // idle or aim pump animation
        if (button_aim)
        {
            // aim animation / animator
            ani.SetInteger("clustershotgun", 5);
        }
        if (!button_aim)
        {
            // idle animation / animator
            ani.SetInteger("clustershotgun", 9);
        }

        yield return new WaitForSeconds(0.4f);

        in_shoot = false;

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


    public void shoot_raycast()
    {
        // Increasing spread at automatic fire / reset if not fired
        current_spread = spread_height;

        Vector3 Add_spread = Shoot_start_point.transform.forward;

        float hor = Random.Range(-current_spread, current_spread);
        float ver = Random.Range(-current_spread, current_spread);


        // merge of horizontal and vertical spread to add it to the shoot rotation
        Add_spread = new Vector3(hor, ver,0 );

        // Checking, if the bullet hasn't been stop -> stopping at hard ground, you can set, how much flesh a bullet can pass, it passes glass unlimted, if it isn't broken already
      

        RaycastHit hit;

        // shooting forward at postion and rotation Shoot_start_point + adding the Spread

        // execute the shooting from an seperate script, to not slowing down the firerate
        shoot_handle.GetComponent<shoot_handle>().register_shoot(Cam.transform.position, Cam.transform.TransformDirection(Vector3.forward - Add_spread), Joule);
    }



    public IEnumerator reload_start()
    {

        // blocking other key input to interprut the reload and blocking shoot with turning on in_reload and finished_reload_in_reload
        in_reload = true;
        finished_reload_in_reload = false;
        bullet_mesh.SetActive(true);

            //reloading animation

            reload_time = 0.834f;
            ani.SetInteger("clustershotgun", 3); // unempty reload    - putting aduioclip on new spawned empty object and transform parent it to the point Shoot_start_point for a static sound

            GameObject g = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
            g.GetComponent<AudioSource>().clip = reload_sound;
            g.GetComponent<AudioSource>().maxDistance = 15;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = Shoot_start_point.transform;
     


        // reload time over
        yield return new WaitForSeconds(reload_time);


        // reloading bullet
        magazine_current += 1;
        stored_bullets -= 1;

        // releasing weapon for the update function, to get shooted again
        finished_shoot = true;
        in_reload = false;
        bullet_mesh.SetActive(false);

        // contiue reloading, if able
        if ( magazine_current == magazine_max)
        {

            // pump sound effect

            GameObject g2 = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
            g2.GetComponent<AudioSource>().clip = pump_sound;
            g2.GetComponent<AudioSource>().maxDistance = 10;
            g2.GetComponent<AudioSource>().Play();
            g2.transform.parent = Shoot_start_point.transform;


            // idle or aim pump animation
            if (button_aim)
            {
                // aim animation / animator
                ani.SetInteger("clustershotgun", 5);
            }
            if (!button_aim)
            {
                // idle animation / animator
                ani.SetInteger("clustershotgun", 9);
            }

            yield return new WaitForSeconds(0.7f);
            StopCoroutine(reload_start());

        }
        if((magazine_current < magazine_max)&& stored_bullets > 0)
        {
            reloading = StartCoroutine(reload_start());
        }


    }



    public GameObject Cam;
    public Animator ani;


    // camera positions for different scopes and states as 3rd
    public Vector3 idle_cam;
    public Vector3 aim_cam;
    public Vector3 run_cam;





    public bool lamp_a_bool;
    public bool lamp_laser_a_bool;
    public bool lamp_laser_b_bool;
    public bool laser_a_bool;

    public bool red_dot_a_bool;
    public bool red_dot_b_bool;
    public bool red_dot_c_bool;
    public bool red_dot_d_bool;
    public bool red_dot_e_bool;

    public bool scope_a_bool;
    public bool scope_b_bool;
    public bool scope_c_bool;



    public GameObject lamp_a;
    public GameObject lamp_laser_a;
    public GameObject lamp_laser_b;
    public GameObject laser_a;

    public GameObject red_dot_a;
    public GameObject red_dot_b;
    public GameObject red_dot_c;
    public GameObject red_dot_d;
    public GameObject red_dot_e;

    public GameObject scope_a;
    public GameObject scope_b;









    public Vector3 shoot_origin;


    public void cam_equipment()
    {

        // changing cam postion for different situation as 3rd and running and different little postion at different scopes


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
        if (button_aim && !running && !in_reload && !scope) //aim
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, aim_cam, 15 * Time.deltaTime);

        }
        if (running && !in_reload)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, run_cam, 15 * Time.deltaTime);
        }



    }


    public bool scope;

 



    public void change_equipment()
    {

        // script to prepare the weapon, or if a scope has been changed to update the mesh status.




        // shoot position
        Shoot_start_point.transform.localPosition = shoot_origin;


   




        // rolling up new equipment/changes
        cam_equipment();

    }



    public void turn_off_weapon()
    {

        // reset all, also the animation to -1, that none animations from an different gun, runs into the animation/with the current one, or the result would be awful and not wished

        ani.SetInteger("clustershotgun", -1);



    }



    public GameObject bullet_shell;
    public GameObject Bullet_shell_output;
    public Vector3 Bullet_shell_output_position;

    public void bullet_drop()
    {

        bullet_shell.transform.localPosition = Bullet_shell_output_position;

        GameObject b = Instantiate(bullet_shell, Bullet_shell_output.transform.position, Bullet_shell_output.transform.rotation);

        b.GetComponent<Rigidbody>().AddForce(Bullet_shell_output.transform.right + Bullet_shell_output.transform.up, ForceMode.Impulse);


    }








}
