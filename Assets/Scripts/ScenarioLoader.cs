using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScenarioLoader : MonoBehaviour
{
    //Add seperate text object for each object
    public GameObject convictText;
    public GameObject notEnoughText;
    public GameObject evidenceCollected;
    public GameObject menu;
    public GameObject pauseCheck;
    public GameObject notebookPause;
    public bool inReach;

    void Start()
    {
        inReach = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && pauseCheck.activeSelf)
        {
            Time.timeScale = 0f;
            Cursor.lockState = CursorLockMode.None;
            convictText.SetActive(false);
            menu.SetActive(true);
            notebookPause.SetActive(false);
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
