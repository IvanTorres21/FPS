using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformTimeStop : MonoBehaviour
{
    Rigidbody rb;
    PlayerTimeController playerTimeController;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        playerTimeController = FindObjectOfType<PlayerTimeController>();
    }

    private void Update()
    {
        if(playerTimeController.isTimePaused && !rb.isKinematic)
        {
            rb.isKinematic = true;
        } else if(!playerTimeController.isTimePaused && rb.isKinematic)
        {
            rb.isKinematic = false;
        }
    }
}
