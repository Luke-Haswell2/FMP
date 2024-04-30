using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScenarioLoader : MonoBehaviour
{
    //Add seperate text object for each object
    public GameObject notEnoughText;

    public bool inReach;

    public GameObject menu;

    public GameObject evidenceCollected;
    public GameObject convictText;

    void Start()
    {
        inReach = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach)
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            convictText.SetActive(false);
            menu.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach" && evidenceCollected.activeSelf == false)
        {
            //inReach = true;
            notEnoughText.SetActive(true);
        }

        if (other.gameObject.tag == "Reach" && evidenceCollected.activeSelf)
        {
            inReach = true;
            convictText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach" && evidenceCollected.activeSelf == false)
        {
            //inReach = false;
            notEnoughText.SetActive(false);
        }

        if (other.gameObject.tag == "Reach" && evidenceCollected.activeSelf)
        {
            inReach = false;
            convictText.SetActive(false);
        }
    }
}
