using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class driver_script : MonoBehaviour
{





    public bool is_driver;
    public bool is_co_driver_1;
    public bool is_co_driver_2;
    public bool is_co_driver_3;

    public Animator ani;


    public GameObject vehicle;

    public GameObject[] skins;
    public int skin_ID;


    private void OnEnable()
    {
        foreach(GameObject g in skins)
        {
            g.SetActive(false);
        }

        skins[skin_ID].SetActive(true);
    }




    public void Start()
    {

        saved_roation_y_head = head_bone.transform.localEulerAngles.y;
        saved_roation_z_head = head_bone.transform.localEulerAngles.z;


        GameObject target_add = GameObject.FindGameObjectWithTag("targets");

        target_add.GetComponent<targets_for_bunny>().Add_Target(gameObject);

      
    }


    bool already_left;
    bool already_chose;

    public bool is_quad;
    public bool is_8x8;

    public GameObject TANK_camera;
    public GameObject TANK_camera_3rd;
    public float tank_camera_3rd_rotaion;

    void LateUpdate()
    {



        // determine, if im the driver, this setting is already setted by the player boxes, the front driver_prefab is always the driver, yyou just turn off and on the co and normal driver

        if (is_quad)
        {
            if (is_driver)
            {
                // setting animation 
                ani.SetInteger("legs", 6);
                vehicle.GetComponent<quad_controll>().Driver();

                // leaving vehicle, checking infos, if ligit
                if (Input.GetKeyDown(KeyCode.X) && vehicle.GetComponent<quad_controll>().driver_seat_player != null && !already_left)
                {
                    already_left = true;
                    vehicle.GetComponent<quad_controll>().driver_seat_player.SetActive(true);

                    // turning of the controller of the normal player, which entered the vehicle, which turned off, now we teleport him to the exit vehicle
                    vehicle.GetComponent<quad_controll>().driver_seat_player.GetComponent<CharacterController>().enabled = false;
                    vehicle.GetComponent<quad_controll>().driver_seat_player.transform.position = transform.position + new Vector3(0, 2, 0);
                    vehicle.GetComponent<quad_controll>().driver_seat_player.GetComponent<CharacterController>().enabled = true;

                    vehicle.GetComponent<quad_controll>().driving_sit = false;
                    vehicle.GetComponent<quad_controll>().driver.SetActive(false);
                    vehicle.GetComponent<quad_controll>().driver_seat_player = null;

                    // getting the headbone back in rotation, as it was at the start 
                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;


                }



                // we are the driver, pressing f2 and you swap to the co driver
                if (Input.GetKeyDown(KeyCode.F2) && !vehicle.GetComponent<quad_controll>().driving_co_sit)
                {

                    vehicle.GetComponent<quad_controll>().driving_sit = false;
                    vehicle.GetComponent<quad_controll>().driving_co_sit = true;


                    vehicle.GetComponent<quad_controll>().driver_co_seat_player = vehicle.GetComponent<quad_controll>().driver_seat_player;
                    vehicle.GetComponent<quad_controll>().driver.SetActive(false);

                    vehicle.GetComponent<quad_controll>().co_driver.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<quad_controll>().co_driver.SetActive(true);
                    vehicle.GetComponent<quad_controll>().driver_seat_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;
                }







            }
            if (!is_driver)
            {
                ani.SetInteger("legs", 7);



                if (Input.GetKeyDown(KeyCode.X) && vehicle.GetComponent<quad_controll>().driver_co_seat_player != null && !already_left)
                {
                    already_left = true;
                    vehicle.GetComponent<quad_controll>().driver_co_seat_player.SetActive(true);

                    vehicle.GetComponent<quad_controll>().driver_co_seat_player.GetComponent<CharacterController>().enabled = false;
                    vehicle.GetComponent<quad_controll>().driver_co_seat_player.transform.position = transform.position + new Vector3(0, 2, 0);
                    vehicle.GetComponent<quad_controll>().driver_co_seat_player.GetComponent<CharacterController>().enabled = true;

                    vehicle.GetComponent<quad_controll>().co_driver.SetActive(false);
                    vehicle.GetComponent<quad_controll>().driving_co_sit = false;
                    vehicle.GetComponent<quad_controll>().driver_co_seat_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;
                }





                if (Input.GetKeyDown(KeyCode.F1) && !vehicle.GetComponent<quad_controll>().driving_sit)
                {

                    vehicle.GetComponent<quad_controll>().driving_sit = true;
                    vehicle.GetComponent<quad_controll>().driving_co_sit = false;


                    vehicle.GetComponent<quad_controll>().driver_seat_player = vehicle.GetComponent<quad_controll>().driver_co_seat_player;
                    vehicle.GetComponent<quad_controll>().driver.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<quad_controll>().driver.SetActive(true);

                    vehicle.GetComponent<quad_controll>().co_driver.SetActive(false);
                    vehicle.GetComponent<quad_controll>().driver_co_seat_player = null;


                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;
                }





            }
        }

        if(is_8x8)
        {
            if (is_driver)
            {
                // setting animation 
                ani.SetInteger("legs", 6);
                vehicle.GetComponent<controll_8x8>().Driver();

                // leaving vehicle, checking infos, if ligit
                if (Input.GetKeyDown(KeyCode.X) && vehicle.GetComponent<controll_8x8>().driver_seat_player != null && !already_left)
                {
                    already_left = true;
                    vehicle.GetComponent<controll_8x8>().driver_seat_player.SetActive(true);

                    // turning of the controller of the normal player, which entered the vehicle, which turned off, now we teleport him to the exit vehicle
                    vehicle.GetComponent<controll_8x8>().driver_seat_player.GetComponent<CharacterController>().enabled = false;
                    vehicle.GetComponent<controll_8x8>().driver_seat_player.transform.position = transform.position + new Vector3(0, 2, 0);
                    vehicle.GetComponent<controll_8x8>().driver_seat_player.GetComponent<CharacterController>().enabled = true;

                    vehicle.GetComponent<controll_8x8>().driving_sit = false;
                    vehicle.GetComponent<controll_8x8>().driver.SetActive(false);
                    vehicle.GetComponent<controll_8x8>().driver_seat_player = null;

                    // getting the headbone back in rotation, as it was at the start 
                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);


                }



                // we are the driver, pressing f2 and you swap to the co driver
                if (Input.GetKeyDown(KeyCode.F2) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_1)
                {

                    vehicle.GetComponent<controll_8x8>().driving_sit = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_1 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player = vehicle.GetComponent<controll_8x8>().driver_seat_player;
                    vehicle.GetComponent<controll_8x8>().driver.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_1.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_seat_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }


                // we are the driver, pressing f2 and you swap to the co driver
                if (Input.GetKeyDown(KeyCode.F3) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_2)
                {

                    vehicle.GetComponent<controll_8x8>().driving_sit = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_2 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player = vehicle.GetComponent<controll_8x8>().driver_seat_player;
                    vehicle.GetComponent<controll_8x8>().driver.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_2.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_2.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_seat_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }


                // we are the driver, pressing f2 and you swap to the co drivere
                if (Input.GetKeyDown(KeyCode.F4) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_3)
                {

                    vehicle.GetComponent<controll_8x8>().driving_sit = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_3 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player = vehicle.GetComponent<controll_8x8>().driver_seat_player;
                    vehicle.GetComponent<controll_8x8>().driver.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_3.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_3.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_seat_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }




            }
            if (is_co_driver_1)
            {
                ani.SetInteger("legs", 7);



                if (Input.GetKeyDown(KeyCode.X) && vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player != null && !already_left)
                {
                    already_left = true;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player.SetActive(true);

                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player.GetComponent<CharacterController>().enabled = false;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player.transform.position = transform.position + new Vector3(0, 2, 0);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player.GetComponent<CharacterController>().enabled = true;

                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(false);
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_1 = false;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;

                }



                if (Input.GetKeyDown(KeyCode.F1) && !vehicle.GetComponent<controll_8x8>().driving_sit)
                {

                    vehicle.GetComponent<controll_8x8>().driving_sit = true;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_1 = false;


                    vehicle.GetComponent<controll_8x8>().driver_seat_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player;
                    vehicle.GetComponent<controll_8x8>().driver.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().driver.SetActive(true);

                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(false);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player = null;


                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;
                    TANK_camera.SetActive(true);
                    TANK_camera_3rd.SetActive(false);
                }



                // we are the driver, pressing f2 and you swap to the co driver
                if (Input.GetKeyDown(KeyCode.F3) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_2)
                {

                    vehicle.GetComponent<controll_8x8>().driving_co_sit_1 = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_2 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player;
                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_2.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_2.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }


                // we are the driver, pressing f2 and you swap to the co drivere
                if (Input.GetKeyDown(KeyCode.F4) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_3)
                {

                    vehicle.GetComponent<controll_8x8>().driving_co_sit_1 = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_3 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player;
                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_3.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_3.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }


            }
            if (is_co_driver_2)
            {
                ani.SetInteger("legs", 7);



                if (Input.GetKeyDown(KeyCode.X) && vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player != null && !already_left)
                {
                    already_left = true;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player.SetActive(true);

                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player.GetComponent<CharacterController>().enabled = false;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player.transform.position = transform.position + new Vector3(0, 2, 0);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player.GetComponent<CharacterController>().enabled = true;

                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(false);
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_2 = false;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;

                }



                if (Input.GetKeyDown(KeyCode.F1) && !vehicle.GetComponent<controll_8x8>().driving_sit)
                {

                    vehicle.GetComponent<controll_8x8>().driving_sit = true;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_2 = false;


                    vehicle.GetComponent<controll_8x8>().driver_seat_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player;
                    vehicle.GetComponent<controll_8x8>().driver.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().driver.SetActive(true);

                    vehicle.GetComponent<controll_8x8>().co_driver_2.SetActive(false);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player = null;


                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;
                    TANK_camera.SetActive(true);
                    TANK_camera_3rd.SetActive(false);
                }


                // we are the driver, pressing f2 and you swap to the co drivere
                if (Input.GetKeyDown(KeyCode.F2) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_1)
                {

                    vehicle.GetComponent<controll_8x8>().driving_co_sit_2 = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_1 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player;
                    vehicle.GetComponent<controll_8x8>().co_driver_2.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_1.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }

                // we are the driver, pressing f2 and you swap to the co drivere
                if (Input.GetKeyDown(KeyCode.F4) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_3)
                {

                    vehicle.GetComponent<controll_8x8>().driving_co_sit_2 = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_3 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player;
                    vehicle.GetComponent<controll_8x8>().co_driver_2.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_3.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_3.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }


            }
            if (is_co_driver_3)
            {
                ani.SetInteger("legs", 7);



                if (Input.GetKeyDown(KeyCode.X) && vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player != null && !already_left)
                {
                    already_left = true;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player.SetActive(true);

                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player.GetComponent<CharacterController>().enabled = false;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player.transform.position = transform.position + new Vector3(0, 2, 0);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player.GetComponent<CharacterController>().enabled = true;

                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(false);
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_3 = false;
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;

                }



                if (Input.GetKeyDown(KeyCode.F1) && !vehicle.GetComponent<controll_8x8>().driving_sit)
                {

                    vehicle.GetComponent<controll_8x8>().driving_sit = true;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_3 = false;


                    vehicle.GetComponent<controll_8x8>().driver_seat_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player;
                    vehicle.GetComponent<controll_8x8>().driver.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().driver.SetActive(true);

                    vehicle.GetComponent<controll_8x8>().co_driver_3.SetActive(false);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player = null;


                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    vehicle_cam_is_3rd = false;
                    TANK_camera.SetActive(true);
                    TANK_camera_3rd.SetActive(false);
                }


                // we are the driver, pressing f2 and you swap to the co drivere
                if (Input.GetKeyDown(KeyCode.F2) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_1)
                {

                    vehicle.GetComponent<controll_8x8>().driving_co_sit_3 = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_1 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_1_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player;
                    vehicle.GetComponent<controll_8x8>().co_driver_3.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_1.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_1.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }

                // we are the driver, pressing f2 and you swap to the co drivere
                if (Input.GetKeyDown(KeyCode.F3) && !vehicle.GetComponent<controll_8x8>().driving_co_sit_2)
                {

                    vehicle.GetComponent<controll_8x8>().driving_co_sit_3 = false;
                    vehicle.GetComponent<controll_8x8>().driving_co_sit_2 = true;


                    vehicle.GetComponent<controll_8x8>().driver_co_seat_2_player = vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player;
                    vehicle.GetComponent<controll_8x8>().co_driver_3.SetActive(false);

                    vehicle.GetComponent<controll_8x8>().co_driver_2.GetComponent<driver_script>().skin_ID = skin_ID;
                    vehicle.GetComponent<controll_8x8>().co_driver_2.SetActive(true);
                    vehicle.GetComponent<controll_8x8>().driver_co_seat_3_player = null;

                    head_bone.transform.localEulerAngles = new Vector3(1.369f, -6.016f, 6.212f);
                    TANK_camera.SetActive(false);
                    TANK_camera_3rd.SetActive(false);
                }



            }

        }





        aimming_vehicle();
        

        already_left = false;



    }



    public GameObject head_bone;

    public float min_angle_head;
    public float max_angle_head;


    float saved_roation_y_head;
    float saved_roation_z_head;
    bool is_toggled;
    public bool vehicle_cam_is_3rd;

    public bool block_first_person_view;


    public float head_speed;
    public GameObject vehicle_camera;

    public void aimming_vehicle()
    {




        Vector3 rot = new Vector3(head_bone.transform.localEulerAngles.x, (saved_roation_y_head) + (Input.GetAxis("Mouse X")) * Time.deltaTime * head_speed, (saved_roation_z_head) - (Input.GetAxis("Mouse Y")) * Time.deltaTime * head_speed);

        // limit of rotation at aimming
        rot.y = Mathf.Clamp(rot.y, min_angle_head, max_angle_head);
        rot.z = Mathf.Clamp(rot.z, min_angle_head, max_angle_head);
        // saving current value to stay at position and not beginning from zero
        saved_roation_y_head = rot.y;
        saved_roation_z_head = rot.z;


        head_bone.transform.localEulerAngles = rot;



        if (is_quad )
        {
          

            if (Input.GetKeyDown(KeyCode.Q) && !is_toggled && !vehicle_cam_is_3rd && !block_first_person_view)
            {
                vehicle_cam_is_3rd = true;
                is_toggled = true;
                vehicle_camera.transform.localPosition = new Vector3(0.024f, 3e-05f, 0);




            }

            if (Input.GetKeyDown(KeyCode.Q) && !is_toggled && vehicle_cam_is_3rd && !block_first_person_view)
            {

                vehicle_cam_is_3rd = false;

                is_toggled = true;
                vehicle_camera.transform.localPosition = new Vector3(-0.00143f, 3e-05f, 0);

            }
        }

        if (is_8x8 && !is_driver)
        {
            

            if (Input.GetKeyDown(KeyCode.Q) && !is_toggled && !vehicle_cam_is_3rd && !block_first_person_view)
            {
                vehicle_cam_is_3rd = true;
                is_toggled = true;
                vehicle_camera.transform.localPosition = new Vector3(0.0475f, 3e-05f, 0);




            }

            if (Input.GetKeyDown(KeyCode.Q) && !is_toggled && vehicle_cam_is_3rd && !block_first_person_view)
            {

                vehicle_cam_is_3rd = false;

                is_toggled = true;
                vehicle_camera.transform.localPosition = new Vector3(0.0475f, 3e-05f, 0);

            }


        }

        if (is_8x8 && is_driver)
        {
           

            if (Input.GetKeyDown(KeyCode.Q) && !is_toggled && !vehicle_cam_is_3rd )
            {
                vehicle_cam_is_3rd = true;
                is_toggled = true;

                
                TANK_camera.SetActive(false);
                TANK_camera_3rd.SetActive(true);


            }

            if (Input.GetKeyDown(KeyCode.Q) && !is_toggled && vehicle_cam_is_3rd )
            {
                
                vehicle_cam_is_3rd = false;

                is_toggled = true;

                TANK_camera.SetActive(true);
                TANK_camera_3rd.SetActive(false);
            }

        }

            is_toggled = false;








    }




}
