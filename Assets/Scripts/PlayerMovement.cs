using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class PlayerMovement : MonoBehaviour
{
    public CharacterController controller;

    public float speed = 3f;
    public float gravity = -9.81f;
    float x;
    float z;

    public bool isSprinting;
    public bool isMoving;
    public bool isRunning;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public GameObject flashlight;

    public bool flashlightEnable;

    void Start()
    {
        isSprinting = false;
        flashlightEnable = false;
        flashlight.SetActive(false);
    }
    void Update()
    {
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        if(isGrounded && velocity.y < 0)
        {
            velocity.y = -2f;
        }

        x = Input.GetAxis("Horizontal");
        z = Input.GetAxis("Vertical");

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = !isSprinting;

            ValidateRunning();
        }

        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            flashlightEnable = !flashlightEnable;

            ValidateFlashlight();
        }

        //Audio

        if (Input.GetKey("w"))
        {

        }
        if (Input.GetKey("a"))
        {

        }
        if (Input.GetKey("s"))
        {

        }
        if (Input.GetKey("d"))
        {

        }
    }

    void FixedUpdate()
    {
        Vector3 move = transform.right * x + transform.forward * z;

        controller.Move(move * speed * Time.deltaTime);

        velocity.y += gravity * Time.deltaTime;

        controller.Move(velocity * Time.deltaTime);
    }

    public void ValidateRunning()
    {
        if (isSprinting == true)
        {
            speed = 8f;
        }
        else
        {
            speed = 3f;
        }
    }

    public void ValidateFlashlight()
    {
        if (flashlightEnable == true)
        {
            flashlight.SetActive(true);
        }
        else
        {
            flashlight.SetActive(false);
        }
    }
}
