using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class CollectEvidence : MonoBehaviour
{
    public GameObject self;
    public GameObject collectText;
    public GameObject inventoryObject;
    public GameObject notebookObject;

    public bool inReach;

    public AudioSource collectSound;

    void Start()
    {
        inReach = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach)
        {
            print("interact worked");
            self.SetActive(false);
            collectSound.Play();
            collectText.SetActive(false);
            inventoryObject.SetActive(true);
            notebookObject.SetActive(true);
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