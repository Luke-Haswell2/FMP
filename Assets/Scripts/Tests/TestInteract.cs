using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteract : MonoBehaviour
{
    public GameObject self;
    public GameObject text;

    public bool inReach;

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
            text.SetActive(false);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = true;
            text.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Reach")
        {
            inReach = false;
            text.SetActive(false);
        }
    }
}
