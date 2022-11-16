
using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class quad_controll : MonoBehaviour
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

    }



    private void Start()
    {
      //   int myLayer = gameObject.layer;
       
      //  Physics.IgnoreLayerCollision(0, myLayer);
    }


    public GameObject front_right_wheel_steer;
    public GameObject front_left_wheel_steer;

    public GameObject front_right_wheel_mesh;
    public GameObject front_left_wheel_mesh;

    public GameObject back_right_wheel_mesh;
    public GameObject back_left_wheel_mesh;

    public GameObject handlebar;

    float rpm_;

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



    public GameObject torque_pointer;
    public GameObject speed_pointer;
    public void Value_gui()
    {

        torque_pointer.transform.localEulerAngles = new Vector3(torque_pointer.transform.localEulerAngles.x, torque_pointer.transform.localEulerAngles.y, (280*((1/maxMotorTorque)*current_motor))-90);
        speed_pointer.transform.localEulerAngles = new Vector3(speed_pointer.transform.localEulerAngles.x, speed_pointer.transform.localEulerAngles.y, ((270f*((1f/70f) * current_speeed))-90));



    }




    public float steer_position;
    bool toggled;
    public float current_speeed;
    public void FixedUpdate()
    {
        current_speeed = GetComponent<Rigidbody>().velocity.magnitude * ((60 * 60) / 1000);

        roll_over_protection();
        Value_gui();

        // wheel mesh rotation

        front_right_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);
        front_left_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);

        back_right_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);
        back_left_wheel_mesh.transform.Rotate(0, -(rpm_ / 60 * 360), 0);

       



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
                // limiting speed on 70 k/mh in unity units
                if (current_speeed < 70)
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

 



        // front wheel sterring
        front_right_wheel_steer.transform.localEulerAngles = new Vector3(current_steerAngle, -89.99001f, -0.013f);

        front_left_wheel_steer.transform.localEulerAngles = new Vector3(current_steerAngle, -89.99001f, -0.013f);

        handlebar.transform.localEulerAngles = new Vector3(0.001f, 0.001f, current_steerAngle);


    }

    public void Driver()
    {




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



        driver.GetComponent<driver_script>().ani.SetFloat("steer_speed", steer_position);







    }






    //  1.707 
    public AudioSource Audio_sourcee;


    public AudioClip idle_engine;
    public AudioClip engine_speed_up;
    public AudioClip engine_max;

    public void engine_sound(bool idle, bool speed_up, bool max_speed,bool Speed_down)
    {

        if(idle && current_motor == 0)
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

        if(max_speed)
        {
            Audio_sourcee.clip = engine_max;
            Audio_sourcee.pitch = 1;
            Audio_sourcee.time = 0;
            Audio_sourcee.Play();
        }




    }


   public  GameObject driver;
   public GameObject co_driver;

   public bool driving_sit;
    public bool driving_co_sit;


    public GameObject driver_seat_player;
    public GameObject driver_co_seat_player;

    public bool already_in_seat;

    public void enter_vehicle(GameObject player,int Skin_ID)
    {
       
        // checking if driver seat is free, if not then entering the co_driving seat, if empty.

        if(!driving_sit)
        {
            driver.GetComponent<driver_script>().skin_ID = Skin_ID;
            driving_sit = true;
            already_in_seat = true;
            driver_seat_player = player;
            driver.SetActive(true);
            // The main player is turned off and an vehicle actor turns on, it's much much better than using the real player, also to not rig the player settings, it might get buggy
            player.SetActive(false);

            

        }

        if(!driving_co_sit && !already_in_seat)
        {
            co_driver.GetComponent<driver_script>().skin_ID = Skin_ID;
            driving_co_sit = true;
            already_in_seat = true;
            driver_co_seat_player = player;
            co_driver.SetActive(true);
            player.SetActive(false);

        }

        already_in_seat = false;



    }


  











}






[System.Serializable]
public class AxleInfo
{
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
    public bool steering; // does this wheel apply steer angle?
}

