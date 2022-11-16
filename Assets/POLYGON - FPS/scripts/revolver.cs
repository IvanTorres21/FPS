using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class revolver : MonoBehaviour
{









    public GameObject recyle_particles_performance;
    public GameObject shoot_handle;
    public void Start()
    {
        shoot_handle = player.GetComponent<polygon_fps_controller>().shoot_handle;
        recyle_particles_performance = GameObject.FindGameObjectWithTag("rycle");
        // if starting with this gun, getting the equipment updated
        _3rd_view = player.GetComponent<polygon_fps_controller>()._3rd;
        Insert_bullets_holder.SetActive(false);
        Insert_bullets.SetActive(false);

        Shoot_start_point.transform.localPosition = shoot_origin;

        


    }


    private void OnEnable()
    {
        in_reload = false;
        in_shoot = false;
    }


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
            Power_bolt -= 0.15f;

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
            current_spread = 0;
        }

        // aim
        if (button_aim && !button_shoot && !in_reload)
        {
            // aim animation / animator
            ani.SetInteger("revolver", 4);
        }
        // idel
        if (!button_aim && !button_shoot && !in_reload)
        {
            // idle animation / animator
            ani.SetInteger("revolver", 0);
        }

        // staying in aim position  :: for adjustments
        //  button_aim = true;


        // walking states /  not accessable while reloading
        if (walking && !in_reload)
        {
            if (!button_aim)
            {
                // idle with walking
                ani.SetInteger("revolver", 2);

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
                ani.SetInteger("revolver", 6);

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

        //  ani.SetInteger("lock", 4);

        // running animation at animator
        if (running && !in_reload)
        {

            ani.SetInteger("revolver", 8);



        }


        // aim shoot animation at animator   // blocked while reloading and with a empty magazine
        if (button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("revolver", 7);
        }
        // idle shoot animation at animator   // blocked while reloading and with a empty magazine
        if (!button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("revolver", 1);
        }

        // execute reloading
        if (reload && !in_reload && stored_bullets > 0 && magazine_current != magazine_max)
        {
            reloading = StartCoroutine(reload_start());

        }



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


    public bool silence;
    public AudioClip shoot_sound;





    public int Joule;




    public float vertical_force;
    public float horizontal_force;

    public float spread_height;
    public float current_spread;


    public int flesh_count;
    bool bullet_stopped;

    public IEnumerator shoot()
    {

        yield return new WaitForSeconds(0);


        // The bullet can pass unlimted glass and a serveral amount of flesh and will stoped by hard ground as wood and stone  /  Here it gets refreshed

        bullet_stopped = false;



        // Increasing spread at automatic fire / reset if not fired                 Suppressor -> 33 % less spread
        current_spread += spread_height;

        Vector3 Add_spread = Shoot_start_point.transform.forward;

        float hor = Random.Range(-current_spread, current_spread);
        float ver = Random.Range(-current_spread, current_spread);


        // merge of horizontal and vertical spread to add it to the shoot rotation
        Add_spread = new Vector3(hor, ver, 0);




        // The Shoot animation isn't looped, if you shoot will a positive time get setted on the animtor/animation/shooting -> Power_bolt
        Power_bolt = 1;



        // addind recoil on aimming -> movement of Polygon_fps_controller 

        float add_ver_force = UnityEngine.Random.Range(0, vertical_force);
        float add_hor_force = UnityEngine.Random.Range(-horizontal_force, horizontal_force);

        // adding shooting for to the aimming camera
      
            player.GetComponent<polygon_fps_controller>().vertical_float_spread = -add_ver_force;
            player.GetComponent<polygon_fps_controller>().horizontal_float_spread = add_hor_force;
        




        // starting muzzle for shooting
        GameObject spawned_muzzle = Instantiate(muzzle, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
        spawned_muzzle.GetComponent<muzzle_flash>().origin = Shoot_start_point;


        // adding shoot sound
      
            GameObject g = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
            g.GetComponent<AudioSource>().clip = shoot_sound;
            g.GetComponent<AudioSource>().maxDistance = 100;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = Shoot_start_point.transform;
     


        // Checking, if the bullet hasn't been stop -> stopping at hard ground, you can set, how much flesh a bullet can pass, it passes glass unlimted, if it isn't broken already
        energy_left:

        RaycastHit hit;

        // shooting forward at postion and rotation Shoot_start_point + adding the Spread

        // execute the shooting from an seperate script, to not slowing down the firerate
        shoot_handle.GetComponent<shoot_handle>().register_shoot(Cam.transform.position, Cam.transform.TransformDirection(Vector3.forward - Add_spread), Joule);

        // turning delay for shoot in semi shoot mode off for bnetter experience
        if (full_auto)
        {
            yield return new WaitForSeconds(firerate);
        }


        // minus for the magazine of the weapon here
        magazine_current -= 1;

        // removing bullet heads exmaple, if less than 6 bullet, can't there be 6 active heads and i turning of the 6th head, all, until 0
        if(magazine_current < 6)
        {
            bullet_head_f.SetActive(false);
        }
        if (magazine_current < 5)
        {
            bullet_head_e.SetActive(false);
        }
        if (magazine_current < 4)
        {
            bullet_head_d.SetActive(false);
        }
        if (magazine_current < 3)
        {
            bullet_head_c.SetActive(false);
        }
        if (magazine_current < 2)
        {
            bullet_head_b.SetActive(false);
        }
        if (magazine_current < 1)
        {
            bullet_head_a.SetActive(false);
        }


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
    public AudioClip reload_unempty;
    public AudioClip reload_empty;


    Coroutine reloading;
    bool in_reload;
    float reload_time;
    bool finished_reload_in_reload;

    public GameObject Clip_on_point;

    public GameObject Insert_bullets;  // bullets to put them in drum;
    public GameObject Insert_bullets_holder; // Holder of the bullets

    public GameObject bullet_head_a;
    public GameObject bullet_head_b;
    public GameObject bullet_head_c;
    public GameObject bullet_head_d;
    public GameObject bullet_head_e;
    public GameObject bullet_head_f;

    public GameObject[] Bullet_bodies;



    public IEnumerator reload_start()
    {

        // blocking other key input to interprut the reload and blocking shoot with turning on in_reload and finished_reload_in_reload
        in_reload = true;
        finished_reload_in_reload = false;


        yield return new WaitForSeconds(0.0001f);   // little delay

        ani.SetInteger("revolver", 3); //  reload

        GameObject g = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
        g.GetComponent<AudioSource>().clip = reload_empty;
        g.GetComponent<AudioSource>().maxDistance = 15;
        g.GetComponent<AudioSource>().Play();
        g.transform.parent = Shoot_start_point.transform;

        yield return new WaitForSeconds(0.874f); // turning off droped out bullets

        for (int i = 0; i < Bullet_bodies.Length; i++)
        {
            Bullet_bodies[i].SetActive(false);
        }

        bullet_head_a.SetActive(false);
        bullet_head_b.SetActive(false);
        bullet_head_c.SetActive(false);
        bullet_head_d.SetActive(false);
        bullet_head_e.SetActive(false);
        bullet_head_f.SetActive(false);


        yield return new WaitForSeconds(0.167f); // turning on bullet + holder to insider in revolver drum

        Insert_bullets.SetActive(true);
        Insert_bullets_holder.SetActive(true);

        yield return new WaitForSeconds(0.458f); // turning off the 6 bullets to insert and turning the real bullets in the drum on

        Insert_bullets_holder.SetActive(false);

        for(int i =0;i<Bullet_bodies.Length;i++)
        {
            Bullet_bodies[i].SetActive(true);
        }

        bullet_head_a.SetActive(true);
        bullet_head_b.SetActive(true);
        bullet_head_c.SetActive(true);
        bullet_head_d.SetActive(true);
        bullet_head_e.SetActive(true);
        bullet_head_f.SetActive(true);


        yield return new WaitForSeconds(0.042f); // turning off  bullet_holder for insert

        Insert_bullets_holder.SetActive(false);
        Insert_bullets.SetActive(false);


        // reload time over
        yield return new WaitForSeconds(0.8f);


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
        in_shoot = false;
        // stopping all runs for reloading
        StopCoroutine(reload_start());

    }



    public GameObject Cam;
    public Animator ani;


    // camera positions for different scopes and states as 3rd
    public Vector3 idle_cam;
    public Vector3 aim_cam;
    public Vector3 run_cam;














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

        ani.SetInteger("revolver", -1);

 






    }


    public GameObject bullet_shell;
    public GameObject Bullet_shell_output;
    public Vector3 Bullet_shell_output_position;










}
