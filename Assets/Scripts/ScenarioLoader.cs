using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScenarioLoader : MonoBehaviour
{
    //Add seperate text object for each object
    public GameObject collectText;

    public bool inReach;

    public GameObject menu;

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
            collectText.SetActive(false);
            menu.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            collectText.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            collectText.SetActive(false);
        }
    }
}
