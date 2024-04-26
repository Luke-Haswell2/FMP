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
    public bool check;
    public bool isRunning;

    public Transform groundCheck;
    public float groundDistance = 0.4f;
    public LayerMask groundMask;

    Vector3 velocity;
    bool isGrounded;

    public GameObject flashlight;

    public bool flashlightEnable;

    public AudioSource flashlightClick;

    public float footstepTimer = 0;

    public AudioSource footsteps;
    public AudioClip grassWalk;
    public AudioClip stoneWalk;
    public AudioClip tileWalk;
    public AudioClip woodWalk;
    public AudioClip metalWalk;
    public AudioClip carpetWalk;
    public AudioClip grassRun;
    public AudioClip stoneRun;
    public AudioClip tileRun;
    public AudioClip woodRun;
    public AudioClip metalRun;
    public AudioClip carpetRun;

    void Start()
    {
        check = true;
        isSprinting = false;
        isMoving = false;
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
            flashlightClick.Play();

            ValidateFlashlight();
        }

        FootstepChecker();

        if (check == true)
        {
            //print(x + " " + z);
            //print(isMoving);
            //print(isRunning);
        }
        if (x != 0)
        {
            isMoving = true;
        }
        if (z != 0)
        {
            isMoving = true;
        }
        if (x == 0 && z == 0)
        {
            isMoving = false;
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
            isRunning = true;
        }
        else
        {
            speed = 3f;
            isRunning = false;
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

    public void FootstepChecker()
    {
        if (!isMoving) return;

        RaycastHit hit;

        footstepTimer -= Time.deltaTime;
        
        if (footstepTimer <= 0)
        {
            Physics.Raycast(transform.position, Vector3.down, out hit, 2f);

            if (isRunning)
            {
                switch (hit.transform.tag)
                {
                    case "Grass":
                        footsteps.PlayOneShot(grassRun);
                        break;
                    case "Stone":
                        footsteps.PlayOneShot(stoneRun);
                        break;
                    case "Tile":
                        footsteps.PlayOneShot(tileRun);
                        break;
                    case "Wood":
                        footsteps.PlayOneShot(woodRun);
                        break;
                    case "Metal":
                        footsteps.PlayOneShot(metalRun);
                        break;
                    case "Carpet":
                        footsteps.PlayOneShot(carpetRun);
                        break;
                }
                footstepTimer = 0.4f;
            }
            else
            {
                switch (hit.transform.tag)
                {
                    case "Grass":
                        footsteps.PlayOneShot(grassWalk);
                        break;
                    case "Stone":
                        footsteps.PlayOneShot(stoneWalk);
                        break;
                    case "Tile":
                        footsteps.PlayOneShot(tileWalk);
                        break;
                    case "Wood":
                        footsteps.PlayOneShot(woodWalk);
                        break;
                    case "Metal":
                        footsteps.PlayOneShot(metalWalk);
                        break;
                    case "Carpet":
                        footsteps.PlayOneShot(carpetWalk);
                        break;
                }
                footstepTimer = 0.6f;
            }
        }
    }
}
