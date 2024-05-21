using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteract : MonoBehaviour
{
    public GameObject self;
    public GameObject collectText;
    public GameObject text;
    public GameObject[] evidence;
    public GameObject[] inventory;
    public GameObject[] blankPhotos;
    public GameObject[] notebookButtons;

    public bool inReach;

    public GameObject reachTool;

    public AudioSource collectSound;

    void Start()
    {
        inReach = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && reachTool.activeSelf)
        {
            print("interact worked");
            self.SetActive(false);
            collectText.SetActive(false);
            text.SetActive(true);
            collectSound.Play();
            foreach (GameObject obj in evidence)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in inventory)
            {
                obj.SetActive(true);
            }
            foreach (GameObject obj in blankPhotos)
            {
                obj.SetActive(false);
            }
            foreach (GameObject obj in notebookButtons)
            {
                obj.SetActive(true);
            }
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
