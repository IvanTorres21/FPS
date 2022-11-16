using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.TestTools;

public class controll_8x8 : MonoBehaviour
{

    public List<AxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel

    public float maxSteeringAngle; // maximum steer angle the wheel can have
    public float minSteeringAngle; // maximum steer angle the wheel can have

    public float current_motor;
    public float motor_speed;


    public float current_steerAngle;
    public float steer_speed;





    void OnEnable()
    {
        WheelCollider WheelColliders = GetComponentInChildren<WheelCollider>();
        WheelColliders.ConfigureVehicleSubsteps(2500, 20, 20); //(1000,20,20) = substeps fixed in 20        fixing shaking

        in_reload = false;
        in_shoot = false;



        Rigidbody[] cols = gameObject.GetComponents<Rigidbody>();

        foreach (Rigidbody c in cols)
        {
            c.centerOfMass = new Vector3(-1.142f, 0.002f, -0.61f);
        }
    }



    private void Start()
    {
        
    }

    public GameObject right_1_wheel_STEER;
    public GameObject left_1_wheel_STEER;

    public GameObject right_2_wheel_STEER;
    public GameObject left_2_wheel_STEER;


    public GameObject right_1_wheel_mesh;
    public GameObject left_1_wheel_mesh;

    public GameObject right_2_wheel_mesh;
    public GameObject left_2_wheel_mesh;


    public GameObject right_3_wheel_mesh;
    public GameObject left_3_wheel_mesh;

    public GameObject right_4_wheel_mesh;
    public GameObject left_4_wheel_mesh;



    public  float rpm_;

    bool idle_already;
    bool speed_up_already;
    bool max_already;

    public bool player_driving;


    public void roll_over_protection()
    {
        float z = transform.localEulerAngles.z;
        float x = transform.localEulerAngles.x;



        if (z < 360 && z > 180)
        {
            z = Mathf.Clamp(z, 315, 360);
        }
        if (z < 180 && z > 0)
        {
            z = Mathf.Clamp(z, 0, 45);
        }


        if (x < 360 && x > 180)
        {
            x = Mathf.Clamp(x, 315, 360);
        }
        if (x < 180 && x > 0)
        {
            x = Mathf.Clamp(x, 0, 45);
        }



     



        transform.localEulerAngles = new Vector3(x, transform.localEulerAngles.y, z);


    }








    public float steer_position;
    bool toggled;
    public float current_speeed;
    public void FixedUpdate()
    {
        current_speeed = GetComponent<Rigidbody>().velocity.magnitude * ((60 * 60) / 1000);

        roll_over_protection();


        gameObject.GetComponent<Rigidbody>().AddForce(new Vector3(0, 0.1f, 0));


        // putting power in wheels and steerling / virtuel
        foreach (AxleInfo axleInfo in axleInfos)
        {
            if (axleInfo.steering)
            {
                axleInfo.leftWheel.steerAngle = current_steerAngle;
                axleInfo.rightWheel.steerAngle = current_steerAngle;


                current_steerAngle = axleInfo.rightWheel.steerAngle;


            }
            if (axleInfo.motor)
            {
                // limiting speed on 60 k/mh in unity units
                if (current_speeed < 60)
                {

                    axleInfo.leftWheel.motorTorque = current_motor / 1.25f;
                    axleInfo.rightWheel.motorTorque = current_motor / 1.25f;


                    axleInfo.leftWheel.motorTorque = current_motor / 1.25f;
                    axleInfo.rightWheel.motorTorque = current_motor / 1.25f;

                }
                else
                {
                    axleInfo.leftWheel.motorTorque = 0;
                    axleInfo.rightWheel.motorTorque = 0;


                    axleInfo.leftWheel.motorTorque = 0;
                    axleInfo.rightWheel.motorTorque = 0;
                }

                // stopping the vehicle
                if (Input.GetKey(KeyCode.Space))
                {

                    GetComponent<Rigidbody>().drag = 8;

                }
                else
                {

                    GetComponent<Rigidbody>().drag = 0;



                }

                rpm_ = axleInfo.leftWheel.rpm;


            }
        }



        // wheel mesh rotation

        right_1_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);
        left_1_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);

        right_2_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);
        left_2_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);


        right_3_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);
        left_3_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);

        right_4_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);
        left_4_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);




        // front wheel sterring
        right_1_wheel_STEER.transform.localEulerAngles = new Vector3(current_steerAngle, -89.99001f, -0.013f);

        left_1_wheel_STEER.transform.localEulerAngles = new Vector3(current_steerAngle, -89.99001f, -0.013f);



        right_2_wheel_STEER.transform.localEulerAngles = new Vector3(current_steerAngle, -89.99001f, -0.013f);

        left_2_wheel_STEER.transform.localEulerAngles = new Vector3(current_steerAngle, -89.99001f, -0.013f);

        //   handlebar.transform.localEulerAngles = new Vector3(0.001f, 0.001f, current_steerAngle);


    }

    public GameObject tank_TOWER;
    public float tank_tower_speed;

    public GameObject Canon;
    public float Canon_speed;

    public float Vehicle_degree_saved_X;

    public float saved_canon_degree;

    bool run_only_once;

    float canon_stable;

    float saved_a;

    public void convert_euler( float a, float b)
    {

        float a_ = 360;
        float b_ = 360;

        if(a > 180)
        {
           a_ -= a;
            a_ = -a_;

        }
        else
        {

            a_ = a;

        }
        if (b > 180)
        {
            b_ -= b;
            b_ = -b_;

           
        }
        else
        {
            b_ = b;
        }

        saved_a = a_;
        canon_stable = a_ - b_;


    }


    public GameObject _40mm_grenade;
    public GameObject _40mm_muzzle_point;
    public GameObject _40mm_muzzle;
    public AudioClip _40mm_shoot_sound;
    public AudioClip _40mm_reload_sound;

  

    public GameObject Audio_holder;
    public LayerMask mask_ignore;
    public int which_weapon;
    bool switched_weapon;
    public AudioClip click;
    public void Driver()
    {



        if(Input.GetKeyDown(KeyCode.F) && !in_reload)
        {
            AudioSource.PlayClipAtPoint(click, transform.position);
            in_shoot = false;

            if (which_weapon < 3)
            {
                which_weapon += 1;
                switched_weapon = true;
            }
            if(which_weapon == 3 && !switched_weapon)
            {
                which_weapon = 1;
            }
            switched_weapon = false;

            if (which_weapon == 1)
            {
                Ammo_40mm = true;
                Ammo_machine_gun = false;
                Ammo_anti_tank_rocket = false;
            }
            if (which_weapon == 2)
            {
                Ammo_40mm = false;
                Ammo_machine_gun = true;
                Ammo_anti_tank_rocket = false;
            }
            if (which_weapon == 3)
            {
                Ammo_40mm = false;
                Ammo_machine_gun = false;
                Ammo_anti_tank_rocket = true;
            }


            if (Anti_tank_rocket_current < 1 && Ammo_anti_tank_rocket)
            {
                
                    reload_status.text = "Empty";
                
            }

            if (Anti_tank_rocket_current > 0 && Ammo_anti_tank_rocket)
            {

                reload_status.text = "Ready";

            }


            if (machine_gun_current < 1 && Ammo_machine_gun)
            {
                Debug.Log("Its emptttyy !!");
                reload_status.text = "Empty";
            }
            if (machine_gun_current > 0 && Ammo_machine_gun)
            {

                reload_status.text = "Ready";

            }



            if (_40mm_magazine_current < 1 && Ammo_40mm)
            {
                reload_status.text = "Empty";
            }
            if (_40mm_magazine_current > 0 && Ammo_40mm)
            {

                reload_status.text = "Ready";

            }


        }



        float a = saved_a;
        float b = transform.localEulerAngles.x;

        convert_euler(saved_a, b);

        saved_a = transform.localEulerAngles.x;


        shooting();



        run_only_once = false;


        if (Input.GetKey(KeyCode.W))
        {
            if (current_motor < maxMotorTorque)
            {
                current_motor += motor_speed;
            }

            if (current_motor != maxMotorTorque)
            {
                max_already = false;
                idle_already = false;

                if (!speed_up_already && current_motor < maxMotorTorque)
                {
                    engine_sound(false, true, false, false);
                    speed_up_already = true;
                }
            }

        }
        if (Input.GetKey(KeyCode.S))
        {
            if (current_motor > -maxMotorTorque)
            {
                current_motor -= motor_speed;
            }

            if (current_motor != -maxMotorTorque)
            {
                max_already = false;
                idle_already = false;

                if (!speed_up_already && current_motor < maxMotorTorque)
                {
                    engine_sound(false, true, false, false);
                    speed_up_already = true;
                }
            }

        }


        if ((Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S)) && current_motor == maxMotorTorque || current_motor == -maxMotorTorque)
        {


            speed_up_already = false;
            idle_already = false;

            if (!max_already)
            {

                engine_sound(false, false, true, false);
                max_already = true;
            }




        }






        if (!Input.GetKey(KeyCode.W) && !Input.GetKey(KeyCode.S))
        {
            if (current_motor < 0)
            {
                current_motor += motor_speed * 10;

                if (current_motor > -20)
                {
                    current_motor = 0;
                }
            }
            if (current_motor > 0)
            {
                current_motor -= motor_speed * 10;

                if (current_motor < 20)
                {
                    current_motor = 0;
                }
            }


            if (current_motor == 0)
            {
                max_already = false;
                speed_up_already = false;

                if (!idle_already)
                {
                    engine_sound(true, false, false, false);
                    idle_already = true;
                }
            }

            if (current_motor > 0 && current_motor < maxMotorTorque)
            {

                if (current_motor < maxMotorTorque)
                {
                    max_already = false;
                    idle_already = false;

                    if (!speed_up_already && current_motor < maxMotorTorque)
                    {
                        engine_sound(false, false, false, true);
                        speed_up_already = true;
                    }
                }
            }



        }





        if (Input.GetKey(KeyCode.D))
        {
            if (current_steerAngle < maxSteeringAngle)
            {
                current_steerAngle += steer_speed;
            }

        }
        if (Input.GetKey(KeyCode.A))
        {
            if (current_steerAngle > minSteeringAngle)
            {
                current_steerAngle -= steer_speed;
            }

        }
        if (!Input.GetKey(KeyCode.A) && !Input.GetKey(KeyCode.D))
        {
            if (current_steerAngle < 0)
            {
                current_steerAngle += steer_speed;
            }
            if (current_steerAngle > 0)
            {
                current_steerAngle -= steer_speed;
            }



        }



        if (current_steerAngle == 0)
        {
            steer_position = 0.5f;
        }

        if (current_steerAngle < 0)
        {
            steer_position = 0.5f - ((0.5f / maxSteeringAngle) * (-current_steerAngle));
        }

        if (current_steerAngle > 0)
        {
            steer_position = 0.5f + ((0.5f / maxSteeringAngle) * (current_steerAngle));
        }





        tank_TOWER.transform.localEulerAngles = new Vector3(tank_TOWER.transform.localEulerAngles.x, tank_TOWER.transform.localEulerAngles.y , tank_TOWER.transform.localEulerAngles.z + (Input.GetAxis("Mouse X") * tank_tower_speed));



       
            Vector3 rot_canon = new Vector3(Canon.transform.localEulerAngles.x, -canon_stable + saved_canon_degree + Input.GetAxis("Mouse Y") * Canon_speed, Canon.transform.localEulerAngles.z);



            if (Canon.transform.localEulerAngles.y > 180 && Canon.transform.localEulerAngles.y < 359)
            {
                rot_canon.y = Mathf.Clamp(rot_canon.y, 350, 360);

            }
            if (Canon.transform.localEulerAngles.y < 180 && Canon.transform.localEulerAngles.y > 1)
            {
                rot_canon.y = Mathf.Clamp(rot_canon.y, 0, 35);


            }



            Canon.transform.localEulerAngles = rot_canon;

            saved_canon_degree = Canon.transform.localEulerAngles.y;


        


            int layerMask = 1 <<8;
            RaycastHit hit;

            if (Physics.Raycast(TANK_camera.transform.position, TANK_camera.transform.TransformDirection(Vector3.forward),out hit, Mathf.Infinity, layerMask))
            {
                _3rd_aim_canon_point = hit.point;
                aim_point_rocket.transform.position = hit.point;
             
            }


            RaycastHit hit_2;

            if (Physics.Raycast(TANK_camera_3rd.transform.position, TANK_camera_3rd.transform.TransformDirection(Vector3.forward), out hit_2, Mathf.Infinity, layerMask))
            {
                _3rd_camera_point = hit_2.point;
        
            }


            float a__ = _3rd_aim_canon_point.y;
            float b__ = _3rd_camera_point.y;



     


      

           float dis_w = Mathf.Abs((a__ - b__)*5);

            if (a__ > (b__))
            {
                _3rd_cam_holder.transform.localEulerAngles = new Vector3(_3rd_cam_holder.transform.localEulerAngles.x, _3rd_cam_holder.transform.localEulerAngles.y + dis_w, _3rd_cam_holder.transform.localEulerAngles.z);
            }
            if (a__ < (b__))
            {
                _3rd_cam_holder.transform.localEulerAngles = new Vector3(_3rd_cam_holder.transform.localEulerAngles.x, _3rd_cam_holder.transform.localEulerAngles.y - dis_w, _3rd_cam_holder.transform.localEulerAngles.z);
            }


        
        RaycastHit hit3;


        if (Ammo_anti_tank_rocket)
            {
                if (Physics.Raycast(TANK_camera.transform.position, TANK_camera.transform.TransformDirection(Vector3.forward), out hit3, Mathf.Infinity, ~mask_ignore))
                {
                
                _3rd_aim_canon_point = hit3.point;
                aim_point_rocket.transform.position = hit3.point;

                }
              
            }




            _8x8_gui();
    }

    public Vector3 _3rd_aim_canon_point;
    public Vector3 _3rd_camera_point;
    public GameObject _3rd_cam_holder;


   


    public GameObject down_up_gui;
    public TextMesh canon_degree;
    public TextMesh ammo_gui;
    public TextMesh distance_gui;
    public TextMesh vehicle_ration;
    public TextMesh reload_status;
    public TextMesh ammo_status;
    public TextMesh speed_gui;

    float a;
    float dis;
    public void _8x8_gui()
    {
       

        if (saved_canon_degree > 180)
        {
            a = 360;

            a -= saved_canon_degree;

            a = -a;

            down_up_gui.transform.localPosition = new Vector3(0, (0.1f * (-a)*0.7f), 0);
            canon_degree.text = (int)a + "°";
        }
        else
        {
            a = saved_canon_degree;

            down_up_gui.transform.localPosition = new Vector3(0, (-0.1f * (a) * 0.7f), 0);
            canon_degree.text = (int)a + "°";
        }

        // min down up    0.1
        // max down up    -0.35

       

        if (Ammo_40mm)
        {
            ammo_gui.text = _40mm_magazine_current + " / " + _40mm_stored_bullets;
        }
        if (Ammo_machine_gun)
        {
            ammo_gui.text = machine_gun_current + " / " + machine_gun_stored_bullets;
        }
        if (Ammo_anti_tank_rocket)
        {
            ammo_gui.text = Anti_tank_rocket_current + " / " + Anti_tank_rocket_stored_bullets;
        }

        float y = (int)transform.eulerAngles.y;

        vehicle_ration.text = y+"°";




        if (TANK_camera.activeSelf)
        {
            RaycastHit hit;

            Physics.Raycast(TANK_camera.transform.position, TANK_camera.transform.TransformDirection(Vector3.forward), out hit);
            

                 dis = Vector3.Distance(TANK_camera.transform.position, hit.point);


             dis = (int)dis;

             distance_gui.text = "  "+dis.ToString();

        }



        speed_gui.text = (int)current_speeed+" Km/h";



        if (Ammo_40mm)
        {
            ammo_status.text = "40mm";
        }
        if (Ammo_machine_gun)
        {
            ammo_status.text = "5.56 mm";
        }

        if(Ammo_anti_tank_rocket)
        {
            ammo_status.text = "Rocket *";
        }
    }





   public bool in_shoot;
    Coroutine shooting_routine;

    bool finished_shoot;

    bool in_reload;

    public bool Ammo_40mm;
    public int _40mm_max_magazine;
    public int _40mm_stored_bullets;
    public bool _40mm_full_auto;
    public float _40mm_firerate;
    public int _40mm_magazine_current;

    public bool Ammo_machine_gun;
    public int machine_gun_max_magazine;
    public int machine_gun_stored_bullets;
    public bool machine_gun_full_auto;
    public float machine_gunfirerate;
    public int machine_gun_current;
    public GameObject machine_gun_point;
    public GameObject machine_gun_muzzle;
    public AudioClip machine_gun_shoot;


    public bool Ammo_anti_tank_rocket;
    public GameObject Anti_tank_rocket;
    public int Anti_tank_rocket_max_magazine;
    public int Anti_tank_rocket_stored_bullets;
    public int Anti_tank_rocket_current;
    public Transform aim_point_rocket;


    public Transform Rocket_slot_1;
    public Transform Rocket_slot_2;
    public Transform Rocket_slot_3;
    public Transform Rocket_slot_4;

    public bool Rocket_slot_1_bool;
    public bool Rocket_slot_2_bool;
    public bool Rocket_slot_3_bool;
    public bool Rocket_slot_4_bool; 


    public GameObject[] all_rockets_loaded;
   

    public Transform rocket_aim;




    public GameObject shoot_handle;


    public void shooting()
    {
        
        Input_checking();

        if(Ammo_40mm)
        {
            _40mm_full_auto = true;
        }
        if (Ammo_machine_gun)
        {
            machine_gun_full_auto = true;
        }
        if(Ammo_anti_tank_rocket)
        {
            if(Input.GetButtonDown("Fire1") && Anti_tank_rocket_current > 0)
            {

                if (Ammo_anti_tank_rocket)
                {



                    if (Rocket_slot_1_bool && !released_rocket)
                    {
                        released_rocket = true;

                      
                        all_rockets_loaded[0].GetComponent<rocket_script>().rocket_ready = true;
                        all_rockets_loaded[0].GetComponent<rocket_script>().aim = rocket_aim;
                        Rocket_slot_1_bool = false;
                        Anti_tank_rocket_current -= 1;
                    }
                    if (Rocket_slot_2_bool && !released_rocket)
                    {
                        released_rocket = true;

            
                        all_rockets_loaded[1].GetComponent<rocket_script>().rocket_ready = true;
                        all_rockets_loaded[1].GetComponent<rocket_script>().aim = rocket_aim;
                        Rocket_slot_2_bool = false;
                        Anti_tank_rocket_current -= 1;
                    }
                    if (Rocket_slot_3_bool && !released_rocket)
                    {
                        released_rocket = true;

                       
                        all_rockets_loaded[2].GetComponent<rocket_script>().rocket_ready = true;
                        all_rockets_loaded[2].GetComponent<rocket_script>().aim = rocket_aim;
                        Rocket_slot_3_bool = false;
                        Anti_tank_rocket_current -= 1;
                    }
                    if (Rocket_slot_4_bool && !released_rocket)
                    {
                        released_rocket = true;

                     
                        all_rockets_loaded[3].GetComponent<rocket_script>().rocket_ready = true;
                        all_rockets_loaded[3].GetComponent<rocket_script>().aim = rocket_aim;
                        Rocket_slot_4_bool = false;
                        Anti_tank_rocket_current -= 1;
                    }


                    released_rocket = false;

                    if(Anti_tank_rocket_current < 1)
                    {
                        if (machine_gun_current == 0)
                        {
                            reload_status.text = "Empty";
                        }
                    }

                }

            }
        }


        // In shooting with a magazine upper than 0 bullets  / not able while reloading and running
        if (button_shoot && !in_shoot && _40mm_magazine_current > 0 && !in_reload )
        {
            in_shoot = true;
            finished_shoot = false;
            shooting_routine = StartCoroutine(shoot_execute());


        }
        // execute reloading 40mm
        if (key_reload && !in_reload && _40mm_stored_bullets > 0 && _40mm_magazine_current != _40mm_max_magazine)
        {
            in_reload = true;
            reloading = StartCoroutine(reload_start());

        }





        if (button_shoot && !in_shoot && machine_gun_current > 0 && !in_reload)
        {
            in_shoot = true;
            finished_shoot = false;
            shooting_routine = StartCoroutine(shoot_execute());


        }

        // execute reloading
        if (key_reload && !in_reload && machine_gun_stored_bullets > 0 && machine_gun_current != machine_gun_max_magazine)
        {
            in_reload = true;
            reloading = StartCoroutine(reload_start());

        }





        // execute reloading
        if (key_reload && !in_reload && Anti_tank_rocket_stored_bullets > 0 && Anti_tank_rocket_current != Anti_tank_rocket_max_magazine)
        {
            in_reload = true;
            reloading = StartCoroutine(reload_start());

        }



        // not in shooting,   recovering current_spread
        if (!button_shoot && finished_shoot)
        {
            in_shoot = false;
        }

    }

    public bool button_shoot;
    bool key_reload;
   public bool released_rocket;

    public void Input_checking()
    {
        if (Input.GetButton("Fire1"))
        {
            button_shoot = true;
        }
        else
        {
            button_shoot = false;
        }

        if (Input.GetKey(KeyCode.R))
        {
            key_reload = true;
        }
        else
        {
            key_reload = false;
        }
    }

    public IEnumerator shoot_execute()
    {
        yield return new WaitForSeconds(0);



        if (Ammo_40mm)
        {


            // starting muzzle for shooting
            Instantiate(_40mm_grenade, _40mm_muzzle_point.transform.position, _40mm_muzzle_point.transform.rotation);
            GameObject spawned_muzzle = Instantiate(_40mm_muzzle, _40mm_muzzle_point.transform.position, _40mm_muzzle_point.transform.rotation);
            spawned_muzzle.GetComponent<muzzle_flash>().origin = _40mm_muzzle_point;


            GameObject g = Instantiate(Audio_holder, _40mm_muzzle_point.transform.position, transform.rotation);
            g.GetComponent<AudioSource>().clip = _40mm_shoot_sound;
            g.GetComponent<AudioSource>().maxDistance = 100;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = _40mm_muzzle_point.transform;



            // turning delay for shoot in semi shoot mode off for bnetter experience
            if (_40mm_full_auto)
            {
                yield return new WaitForSeconds(_40mm_firerate);
            }


            // minus for the magazine of the weapon here
            _40mm_magazine_current -= 1;

            if (_40mm_magazine_current == 0)
            {
                reload_status.text = "Empty";
            }

            // check if magazine has a bullet left to repeat the shooting and if the trigger is pressed down and if fullauto is enabled
            if (_40mm_magazine_current > 0 && _40mm_full_auto && button_shoot)
            {
                StopCoroutine(shooting_routine);
                shooting_routine = StartCoroutine(shoot_execute());
            }

            // break the shoot, because it is setted on semiauto
            if (!_40mm_full_auto)
            {
                finished_shoot = true;
                StopCoroutine(shooting_routine);
            }
            // no shoot button pressed
            if (!button_shoot)
            {
                finished_shoot = true;
                StopCoroutine(shooting_routine);
            }


        }

 
        if (Ammo_machine_gun)
        {
            Vector3 Add_spread = TANK_camera.transform.forward;

            float hor = Random.Range(-0.01f, 0.01f);
            float ver = Random.Range(-0.01f, 0.01f);


            // merge of horizontal and vertical spread to add it to the shoot rotation
            Add_spread = new Vector3(hor, ver, 0);



            // starting muzzle for shooting

            GameObject spawned_muzzle = Instantiate(machine_gun_muzzle, machine_gun_point.transform.position, machine_gun_point.transform.rotation);
            spawned_muzzle.GetComponent<muzzle_flash>().origin = machine_gun_muzzle;

            shoot_handle.GetComponent<shoot_handle>().register_shoot(TANK_camera.transform.position, TANK_camera.transform.TransformDirection(Vector3.forward+Add_spread), 900);


            GameObject g = Instantiate(Audio_holder, machine_gun_point.transform.position, transform.rotation);
            g.GetComponent<AudioSource>().clip = machine_gun_shoot;
            g.GetComponent<AudioSource>().maxDistance = 50;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = machine_gun_point.transform;



            // turning delay for shoot in semi shoot mode off for bnetter experience
            if (machine_gun_full_auto)
            {
                yield return new WaitForSeconds(machine_gunfirerate);
            }


            // minus for the magazine of the weapon here
            machine_gun_current -= 1;

            if (machine_gun_current == 0)
            {
                reload_status.text = "Empty";
            }

            // check if magazine has a bullet left to repeat the shooting and if the trigger is pressed down and if fullauto is enabled
            if (machine_gun_current > 0 && machine_gun_full_auto && button_shoot)
            {
                StopCoroutine(shooting_routine);
                shooting_routine = StartCoroutine(shoot_execute());
            }

            // break the shoot, because it is setted on semiauto
            if (!machine_gun_full_auto)
            {
                finished_shoot = true;
                StopCoroutine(shooting_routine);
            }
            // no shoot button pressed
            if (!button_shoot)
            {
                finished_shoot = true;
                StopCoroutine(shooting_routine);
            }


        }





    }

    bool finished_reload_in_reload;
    Coroutine reloading;


    public IEnumerator reload_start()
    {

        // blocking other key input to interprut the reload and blocking shoot with turning on in_reload and finished_reload_in_reload
        in_reload = true;
        finished_reload_in_reload = false;


        reload_status.text = "Reloading...";

          GameObject g = Instantiate(Audio_holder, _40mm_muzzle_point.transform.position, transform.rotation);
            g.GetComponent<AudioSource>().clip = _40mm_reload_sound;
            g.GetComponent<AudioSource>().maxDistance = 15;
            g.GetComponent<AudioSource>().Play();
            g.transform.parent = _40mm_muzzle_point.transform;
    

        // reload time over
        yield return new WaitForSeconds(3);

        if (Ammo_40mm)
        {

            // if there aren't enough bullet to fill the complet magazine, different reloading handle for bullets
            if (_40mm_stored_bullets < _40mm_max_magazine && !finished_reload_in_reload)
            {
                finished_reload_in_reload = true;
                _40mm_stored_bullets += _40mm_magazine_current;
                _40mm_magazine_current = 0;
                _40mm_magazine_current = _40mm_stored_bullets;
                _40mm_stored_bullets = 0;
            }

            // enough bullets in stored bullets just to fill the full magazine and if the bullets released, will the shooting get unlocked with finished_reload_in_reload
            if (_40mm_stored_bullets > _40mm_max_magazine || _40mm_stored_bullets == _40mm_max_magazine && !finished_reload_in_reload)
            {
                finished_reload_in_reload = true;
                _40mm_stored_bullets += _40mm_magazine_current;
                _40mm_magazine_current = 0;
                _40mm_magazine_current = _40mm_max_magazine;
                _40mm_stored_bullets -= _40mm_max_magazine;
            }

        }

        if (Ammo_machine_gun)
        {

            // if there aren't enough bullet to fill the complet magazine, different reloading handle for bullets
            if (machine_gun_stored_bullets < machine_gun_max_magazine && !finished_reload_in_reload)
            {
                finished_reload_in_reload = true;
                machine_gun_stored_bullets += machine_gun_current;
                machine_gun_current = 0;
                machine_gun_current = machine_gun_stored_bullets;
                machine_gun_stored_bullets = 0;
            }

            // enough bullets in stored bullets just to fill the full magazine and if the bullets released, will the shooting get unlocked with finished_reload_in_reload
            if (machine_gun_stored_bullets > machine_gun_max_magazine || machine_gun_stored_bullets == machine_gun_max_magazine && !finished_reload_in_reload)
            {
                finished_reload_in_reload = true;
                machine_gun_stored_bullets += machine_gun_current;
                machine_gun_current = 0;
                machine_gun_current = machine_gun_max_magazine;
                machine_gun_stored_bullets -= machine_gun_max_magazine;
            }

        }

        if (Ammo_anti_tank_rocket)
        {

           if(Anti_tank_rocket_stored_bullets > 0 && !Rocket_slot_1_bool)
           {
                Anti_tank_rocket_stored_bullets -= 1;
                Rocket_slot_1_bool = true;

               GameObject sl1 =  Instantiate(Anti_tank_rocket, Rocket_slot_1.transform.position, Rocket_slot_1.transform.rotation);


                sl1.transform.parent = tank_TOWER.transform;
                all_rockets_loaded[0] = sl1;

           }
            if (Anti_tank_rocket_stored_bullets > 0 && !Rocket_slot_2_bool)
            {
                Anti_tank_rocket_stored_bullets -= 1;
                Rocket_slot_2_bool = true;

                GameObject sl2 = Instantiate(Anti_tank_rocket, Rocket_slot_2.transform.position, Rocket_slot_2.transform.rotation);


                sl2.transform.parent = tank_TOWER.transform;
                all_rockets_loaded[1] = sl2;

            }

            if (Anti_tank_rocket_stored_bullets > 0 && !Rocket_slot_3_bool)
            {
                Anti_tank_rocket_stored_bullets -= 1;
                Rocket_slot_3_bool = true;

                GameObject sl3 = Instantiate(Anti_tank_rocket, Rocket_slot_3.transform.position, Rocket_slot_3.transform.rotation);


                sl3.transform.parent = tank_TOWER.transform;
                all_rockets_loaded[2] = sl3;

            }

            if (Anti_tank_rocket_stored_bullets > 0 && !Rocket_slot_4_bool)
            {
                Anti_tank_rocket_stored_bullets -= 1;
                Rocket_slot_4_bool = true;

                GameObject sl4 = Instantiate(Anti_tank_rocket, Rocket_slot_4.transform.position, Rocket_slot_4.transform.rotation);


                sl4.transform.parent = tank_TOWER.transform;
                all_rockets_loaded[3] = sl4;

            }

            Anti_tank_rocket_current = 0;

            if(Rocket_slot_1_bool)
            {
                Anti_tank_rocket_current += 1;
            }
            if (Rocket_slot_2_bool)
            {
                Anti_tank_rocket_current += 1;
            }
            if (Rocket_slot_3_bool)
            {
                Anti_tank_rocket_current += 1;
            }
            if (Rocket_slot_4_bool)
            {
                Anti_tank_rocket_current += 1;
            }






        }






        // releasing weapon for the update function, to get shooted again
        finished_shoot = true;
        in_reload = false;
        // stopping all runs for reloading
        reload_status.text = "Ready";
        StopCoroutine(reload_start());

    }



    //  1.707 
    public AudioSource Audio_sourcee;


    public AudioClip idle_engine;
    public AudioClip engine_speed_up;
    public AudioClip engine_max;

    public void engine_sound(bool idle, bool speed_up, bool max_speed, bool Speed_down)
    {

        if (idle && current_motor == 0)
        {
            Audio_sourcee.clip = idle_engine;
            Audio_sourcee.volume = 1f;
            Audio_sourcee.time = 0;
            Audio_sourcee.Play();
        }


        if (Speed_down)
        {
            Audio_sourcee.clip = engine_speed_up;
            Audio_sourcee.pitch = -1;
            Audio_sourcee.time = Mathf.Min((1.7f - (1.7f * ((1 / maxMotorTorque) * current_motor))), engine_speed_up.length - 0.01f);
            Audio_sourcee.volume = 0.5f;
            Audio_sourcee.Play();
        }





        if (speed_up)
        {
            Audio_sourcee.clip = engine_speed_up;
            Audio_sourcee.pitch = 1;
            Audio_sourcee.time = Mathf.Min((1.7f - (1.7f * ((1 / maxMotorTorque) * current_motor))), engine_speed_up.length - 0.01f);

            Audio_sourcee.volume = 0.5f;
            Audio_sourcee.Play();
        }

        if (max_speed)
        {
            Audio_sourcee.clip = engine_max;
            Audio_sourcee.pitch = 1;
            Audio_sourcee.time = 0;
            Audio_sourcee.Play();
        }




    }


    public GameObject driver;
    public GameObject co_driver_1;
    public GameObject co_driver_2;
    public GameObject co_driver_3;

    public bool driving_sit;
    public bool driving_co_sit_1;
    public bool driving_co_sit_2;
    public bool driving_co_sit_3;

    public GameObject driver_seat_player;
    public GameObject driver_co_seat_1_player;
    public GameObject driver_co_seat_2_player;
    public GameObject driver_co_seat_3_player;

    public bool already_in_seat;
    public GameObject TANK_camera;
    public GameObject TANK_camera_3rd;

    public void enter_vehicle(GameObject player, int Skin_ID)
    {

        // checking if driver seat is free, if not then entering the co_driving seat, if empty.

        if (!driving_sit)
        {
            driver.GetComponent<driver_script>().skin_ID = Skin_ID;
            driving_sit = true;
            already_in_seat = true;
            driver_seat_player = player;
            driver.SetActive(true);
            // The main player is turned off and an vehicle actor turns on, it's much much better than using the real player, also to not rig the player settings, it might get buggy
            player.SetActive(false);
            TANK_camera.SetActive(true);


        }

        if (!driving_co_sit_1 && !already_in_seat)
        {
            co_driver_1.GetComponent<driver_script>().skin_ID = Skin_ID;
            driving_co_sit_1 = true;
            already_in_seat = true;
            driver_co_seat_1_player = player;
            co_driver_1.SetActive(true);
            player.SetActive(false);

        }

        if (!driving_co_sit_2 && !already_in_seat)
        {
            co_driver_2.GetComponent<driver_script>().skin_ID = Skin_ID;
            driving_co_sit_2 = true;
            already_in_seat = true;
            driver_co_seat_2_player = player;
            co_driver_2.SetActive(true);
            player.SetActive(false);

        }

        if (!driving_co_sit_3 && !already_in_seat)
        {
            co_driver_3.GetComponent<driver_script>().skin_ID = Skin_ID;
            driving_co_sit_3 = true;
            already_in_seat = true;
            driver_co_seat_3_player = player;
            co_driver_3.SetActive(true);
            player.SetActive(false);

        }

        already_in_seat = false;



    }






    [System.Serializable]
    public class AxleInfo
    {
        public WheelCollider leftWheel;
        public WheelCollider rightWheel;
        public bool motor; // is this wheel attached to motor?
        public bool steering; // does this wheel apply steer angle?
    }









}






