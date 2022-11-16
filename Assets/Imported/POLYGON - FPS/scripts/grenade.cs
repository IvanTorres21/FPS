using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade : MonoBehaviour
{





   public void Start()
    {
        _3rd_view = player.GetComponent<polygon_fps_controller>()._3rd;


        grenade_mesh.GetComponent<Renderer>().enabled = true;

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





        // throw


        if (button_shoot && !in_shoot && magazine_current > 0 && !running)
        {
            ani.SetInteger("grenade", 3);
            in_shoot = true;
            finished_shoot = false;
            shooting = StartCoroutine(shoot());

        }

     

        // idle
        if (!button_shoot && !in_shoot)
        {
            ani.SetInteger("grenade", 0);
        }



        if (walking && !in_shoot)
        {

            //  walk
            ani.SetInteger("grenade", 1);

            if (duck_walk)
            {
                ani.SetFloat("weapon_speed", 0.5f);
            }
            else
            {
                ani.SetFloat("weapon_speed", 1);
            }

        }

    


        // run 
        if (running && !in_shoot)
        {

            ani.SetInteger("grenade", 2);

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
    public GameObject grenade_to_throw;


    float Push_bolt;



    bool in_shoot;
    Coroutine shooting;
    public bool full_auto;
    bool finished_shoot;



    public AudioClip blast_set_sound;


    public GameObject grenade_mesh;




    public List<GameObject> Throwed_blast_sets = new List<GameObject>();

    public IEnumerator shoot()
    {






        yield return new WaitForSeconds(0.541f);
    

        grenade_mesh.GetComponent<Renderer>().enabled = false;

        magazine_current -= 1;


        // grenades gettign throwed with physic, different angle = different throw result


        // spawning fireball, which has is own sccript to dmage things 
        GameObject spawne_blast = Instantiate(grenade_to_throw, Shoot_start_point.transform.position, Shoot_start_point.transform.rotation);
        Throwed_blast_sets.Add(spawne_blast);
        spawne_blast.GetComponent<Rigidbody>().AddForce((Shoot_start_point.transform.forward * 17), ForceMode.Impulse);

        AudioSource.PlayClipAtPoint(blast_set_sound, Shoot_start_point.transform.position);

        ani.SetInteger("grenade", 0);

        yield return new WaitForSeconds(0.3f);

      

        in_shoot = false;

        if (magazine_current > 0)
        {
            grenade_mesh.GetComponent<Renderer>().enabled = true;
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

        ani.SetInteger("grenade", -1);



    }






}
