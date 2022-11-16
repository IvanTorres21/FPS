using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flamethrower : MonoBehaviour
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


    float Power_bolt;
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

        // Push force against shoot animation, force get added, if shoot to play the animation forward

        if (Power_bolt > -1)
        {
            Power_bolt -= 0.05f;

        }
        if (Power_bolt < -1)
        {
            Power_bolt = -1;
        }

        ani.SetFloat("Power_bolt", Power_bolt);








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

        // idle
        if (button_aim && !button_shoot && !in_reload)
        {
            ani.SetInteger("flamethrower", 0);
            flame_sound_source.SetActive(false);
        }
        // idle
        if (!button_aim && !button_shoot && !in_reload)
        {
            ani.SetInteger("flamethrower", 0);
            flame_sound_source.SetActive(false);
        }

        
        if (walking && !in_reload)
        {

            if (!button_aim)
            {
                //  walk
                ani.SetInteger("flamethrower", 1);

                // slow down duck walk
                if (duck_walk)
                {
                    ani.SetFloat("weapon_speed", 0.5f);
                }
                else
                {
                    ani.SetFloat("weapon_speed", 1);
                }
            }

            if (button_aim)
            {
                //  walk
                ani.SetInteger("flamethrower", 1);

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


        // run 
        if (running && !in_reload)
        {

            ani.SetInteger("flamethrower", 2);

        }


        // idle shoot

        if (button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("flamethrower", 3);

            flame_sound_source.SetActive(true);
        }

        // idle shoot

        if (!button_aim && button_shoot && !running && !in_reload && magazine_current > 0)
        {
            ani.SetInteger("flamethrower", 3);

            flame_sound_source.SetActive(true);
        }


        //reloading
        if (reload && !in_reload && stored_bullets > 0 && magazine_current != magazine_max)
        {
            reloading = StartCoroutine(reload_start());

            flame_sound_source.SetActive(false);
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
    public GameObject flame;


     float Push_bolt;



    bool in_shoot;
    Coroutine shooting;
    public bool full_auto;
    public float firerate;
    bool finished_shoot;


 
    public GameObject flame_sound_source;


    public float max_spread;


    public Vector3 Shoot_start_point_vector3;

    public IEnumerator shoot()
    {

        yield return new WaitForSeconds(0);


        // The Shoot animation isn't looped, if you shoot will a positive time get setted on the animtor/animation/shooting -> Power_bolt
        Power_bolt = 1;

        magazine_current -= 1;


        // Increasing spread at automatic fire / reset if not fired 
        Vector3 Add_spread = Shoot_start_point.transform.forward;

        float hor = Random.Range(-max_spread, max_spread);
        float ver = Random.Range(-max_spread, max_spread);

        Add_spread = new Vector3(0,3+ hor, ver);


        // spawning fireball, which has is own sccript to dmage things 
        GameObject spawne_flame = Instantiate(flame, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
        Transform flame_child = spawne_flame.transform.Find("Sphere");
        flame_child.GetComponent<Rigidbody>().AddForce((Shoot_start_point.transform.TransformDirection(Vector3.forward*15 - Add_spread)), ForceMode.Impulse);





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


    Coroutine reloading;
    bool in_reload;
    float reload_time;
    bool finished_reload_in_reload;

    public GameObject Clip_on_point;
    public IEnumerator reload_start()
    {
        // blocking other key input to interprut the reload and blocking shoot with turning on in_reload and finished_reload_in_reload

        in_reload = true;
        finished_reload_in_reload = false;

        
            reload_time = 2.249f;
            // unempty reload
            ani.SetInteger("flamethrower", 4);

            // putting aduioclip on new spawned empty object and transform parent it to the point Shoot_start_point for a static sound
            GameObject g = Instantiate(Clip_on_point, Shoot_start_point.transform.position, transform.rotation);
            g.GetComponent<AudioSource>().clip = reload_sound;
            g.GetComponent<AudioSource>().maxDistance = 15;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = Shoot_start_point.transform;
      

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

        // turning on flamethrower little flame sound
        flamethrower_defaul_sound.SetActive(true);

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
        if (button_aim && !running && !in_reload ) //aim
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, aim_cam, 15 * Time.deltaTime);

        }
        if (running && !in_reload)
        {
            Cam.transform.localPosition = Vector3.Lerp(Cam.transform.localPosition, run_cam, 15 * Time.deltaTime);
        }








    }

    public GameObject flamethrower_defaul_sound;
    public void turn_off_weapon()
    {
        // reset all, also the animation to -1, that none animations from an different gun, runs into the animation/with the current one, or the result would be awful and not wished

        ani.SetInteger("flamethrower", -1);
        flamethrower_defaul_sound.SetActive(false);


    }

































}
