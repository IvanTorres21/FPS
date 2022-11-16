using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automatic_door : MonoBehaviour
{


    
    public HingeJoint Motor_right;
    public HingeJoint Motor_left;


    public void Start()
    {
        Door_open();
    }


    public AudioClip ClickLever;
    public AudioClip Move_door;
    public AudioSource source;


    Coroutine DoorSoundChange;

    public IEnumerator DoorNewDirectionSound()
    {
      

        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;
        yield return new WaitForSeconds(0.1f);
        source.GetComponent<AudioSource>().volume += 0.03f;

       


        StopCoroutine(DoorSoundChange);
    }



    public void Door_open()
    {

       
        source.GetComponent<AudioSource>().volume = 0;
        DoorSoundChange = StartCoroutine(DoorNewDirectionSound());
       
        source.GetComponent<AudioSource>().pitch = 1.1f;
        JointMotor Motor_right_M = Motor_right.motor;
        Motor_right_M.force = 300;
        Motor_right_M.targetVelocity = 70;

        Motor_right.motor = Motor_right_M;

        JointMotor Motor_left_M = Motor_left.motor;
        Motor_left_M.force = 300;
        Motor_left_M.targetVelocity = 70;

        Motor_left.motor = Motor_left_M;

    }

    public void Door_close()
    {



        source.GetComponent<AudioSource>().volume = 0;
        DoorSoundChange = StartCoroutine(DoorNewDirectionSound());

        source.GetComponent<AudioSource>().pitch = -1.2f;
        JointMotor Motor_right_M = Motor_right.motor;
        Motor_right_M.force = 300;
        Motor_right_M.targetVelocity = -70;

        Motor_right.motor = Motor_right_M;

        JointMotor Motor_left_M = Motor_left.motor;
        Motor_left_M.force = 300;
        Motor_left_M.targetVelocity = -70;

        Motor_left.motor = Motor_left_M;
    }

}
