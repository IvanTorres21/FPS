using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Rendering;

public class PlayerMovementController : MonoBehaviour
{
    [Header("Movement")]
    private float speed = 5f;
    private const float BASE_SPEED = 5f;
    private const float MAX_SPEED = 7f;
    [SerializeField] private bool isGrounded = false;
    private bool hasJumped = false;
    [SerializeField] private float jumpForce = 180f;
    [SerializeField] private Volume postProcessing;

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
        if(Input.GetButtonDown("Jump") && isGrounded && !hasJumped)
        {
            hasJumped = true;
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        } 
    }

    private void MovePlayer()
    {
        if(Input.GetKey(KeyCode.LeftShift))
        {
            speed = MAX_SPEED;
        } else
        {
            speed = BASE_SPEED;
        }

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


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Interacteable"))
        {

            hasJumped = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Interacteable"))
        {
            
            isGrounded = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Ground") || other.gameObject.CompareTag("Interacteable"))
        {
            if(!hasJumped)
            {
                StopCoroutine(jumpWindow());
                StartCoroutine(jumpWindow());
            } else
            {
                isGrounded = false;
            }
        }
    }

    IEnumerator jumpWindow()
    {
        yield return new WaitForSeconds(0.2f);
        isGrounded = false;
    }
}
