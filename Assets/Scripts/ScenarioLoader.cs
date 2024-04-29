using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class ScenarioLoader : MonoBehaviour
{
    //Add seperate text object for each object and text will be "Prosicute *name*, reasoning,evidence,etc" bottom line: "(Left Click)"
    public GameObject collectText;

    //Tick box in inspector for which scene it will be loading
    public bool isAlpha;
    public bool isBravo;
    public bool isCharlie;
    public bool isDelta;

    public bool inReach;

    void Start()
    {
        inReach = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && isAlpha)
        {
            //SceneManager.LoadScene("Scenario Alpha");
            collectText.SetActive(false);
            print("Scene load alpha");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && isBravo)
        {
            //SceneManager.LoadScene("Scenario Bravo");
            collectText.SetActive(false);
            print("Scene load bravo");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && isCharlie)
        {
            //SceneManager.LoadScene("Scenario Charlie");
            collectText.SetActive(false);
            print("Scene load charlie");
        }

        if (Input.GetKeyDown(KeyCode.Mouse0) && inReach && isDelta)
        {
            //SceneManager.LoadScene("Scenario Delta");
            collectText.SetActive(false);
            print("Scene load delta");
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
