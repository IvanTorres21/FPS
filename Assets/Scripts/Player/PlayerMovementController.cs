using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    [Header("Movement")]
    private float speed = 5f;
    [SerializeField] private float jumpForce = 130f;

    [Header("Camera")]
    private float mouseSensitivity = 3f;
    private float minX = -80f;
    private float maxX = 80f;
    private float rotationX;

    private Rigidbody rb;
    private Camera cam;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        cam = Camera.main;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void Update()
    {
        MovePlayer();
        JumpPlayer();
        MoveCamera();
    }

    private void JumpPlayer()
    {
        if(Input.GetButton("Jump"))
        {

            if(jumpForce < 170)
            {
                jumpForce += 30 * Time.deltaTime;
            }
        } else if (Input.GetButtonUp("Jump") && CheckGrounded())
        {
            if (jumpForce >= 170) jumpForce = 170;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            jumpForce = 130;
        }
    }

    private void MovePlayer()
    {
        float x = Input.GetAxis("Horizontal") * speed;
        float z = Input.GetAxis("Vertical") * speed;

        Vector3 direction =transform.right * x + transform.forward * z;
        direction.y = rb.velocity.y;
        rb.velocity = direction; 
    }

    private void MoveCamera()
    {
        float y = Input.GetAxis("Mouse X") * mouseSensitivity;
        rotationX += Input.GetAxis("Mouse Y") * mouseSensitivity;

        rotationX = Mathf.Clamp(rotationX, minX, maxX);

        cam.transform.localRotation = Quaternion.Euler(-rotationX, 0, 0);
        transform.eulerAngles += Vector3.up * y;
    }

    private bool CheckGrounded()
    {
        Ray ray = new Ray(transform.position, Vector3.down);
        if(Physics.Raycast(ray, 1.6f, 1 << 0))
        {
            return true;
        }
        return false;
    }
}
