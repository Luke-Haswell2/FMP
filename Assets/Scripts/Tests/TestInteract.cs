using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestInteract : MonoBehaviour
{
    public GameObject self;
    public GameObject text;
    public GameObject[] evidence;

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
            foreach (GameObject obj in evidence)
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
