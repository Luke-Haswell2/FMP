using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class LightSwitch : MonoBehaviour
{
    public GameObject onSwitch;
    public GameObject offSwitch;

    public GameObject lightText;

    public GameObject lightObject;

    public AudioSource switchSound;

    public bool lightsAreOn;
    public bool lightsAreOff;
    public bool inReach;
    public GameObject reachTool;

    void Start()
    {
        inReach = false;
        lightsAreOn = false;
        lightsAreOff = true;
        onSwitch.SetActive(false);
        offSwitch.SetActive(true);
        lightObject.SetActive(false);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && lightsAreOn && reachTool.activeSelf)
        {
            lightObject.SetActive(false);
            onSwitch.SetActive(false);
            offSwitch.SetActive(true);
            switchSound.Play();
            lightsAreOff = true;
            lightsAreOn = false;
        }

        else if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && lightsAreOff && reachTool.activeSelf)
        {
            lightObject.SetActive(true);
            onSwitch.SetActive(true);
            offSwitch.SetActive(false);
            switchSound.Play();
            lightsAreOff = false;
            lightsAreOn = true;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            lightText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            lightText.SetActive(false);
        }
    }
}
