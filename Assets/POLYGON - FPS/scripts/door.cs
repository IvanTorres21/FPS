using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{


    public HingeJoint Motor_door;
    public AudioClip Door_move_sound;

    public bool conversely;

     bool is_open;


    public void Start()
    {
       
       
    }



    public void door_execute()
    {
        if(is_open)
        {
            is_open = false;
            AudioSource.PlayClipAtPoint(Door_move_sound, transform.position);
            Door_close();

        }
        else
        {
            is_open = true;
            AudioSource.PlayClipAtPoint(Door_move_sound, transform.position);
            Door_open();

        }
    }

    public void Door_open()
    {

        if (!conversely)
        {

            JointMotor Motor_M = Motor_door.motor;
            Motor_M.force = 120;
            Motor_M.targetVelocity = 120;

            Motor_door.motor = Motor_M;

        }
        else
        {
            JointMotor Motor_right_M = Motor_door.motor;
            Motor_right_M.force = 120;
            Motor_right_M.targetVelocity = -120;

            Motor_door.motor = Motor_right_M;
        }

       
    }

    public void Door_close()
    {
        if (!conversely)
        {

            JointMotor Motor_M = Motor_door.motor;
            Motor_M.force = 120;
            Motor_M.targetVelocity = -120;

            Motor_door.motor = Motor_M;

        }
        else
        {
            JointMotor Motor_right_M = Motor_door.motor;
            Motor_right_M.force = 120;
            Motor_right_M.targetVelocity = 120;

            Motor_door.motor = Motor_right_M;
        }

       
    }
}
