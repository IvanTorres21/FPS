using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class vehicle_enter : MonoBehaviour
{
    public GameObject my_vehicle;


    public void send_enter_request(GameObject player, int Skin_ID_)
    {

        my_vehicle.GetComponent<quad_controll>().enter_vehicle(player, Skin_ID_);

    }








}
