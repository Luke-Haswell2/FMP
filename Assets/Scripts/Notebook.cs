using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class Notebook : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject page1;
    public GameObject[] notebookUI;

    public GameObject pauseCheck;

    public GameObject reachTool;
    //public float waitTimer = 0;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.N) && pauseCheck.activeSelf)
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                NotebookActive();
            }
        }
    }

    public void Resume()
    {
        //notebookUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;
        foreach (GameObject obj in notebookUI)
        {
            obj.SetActive(false);
        }

        /*
        waitTimer -= Time.deltaTime;
        if (waitTimer <= 0)
        {
            reachTool.SetActive(true);
        }*/

        Invoke("ReachDelay", 0.1f);
    }

    void NotebookActive()
    {
        //notebookUI.SetActive(true);
        page1.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
        reachTool.SetActive(false);
        //waitTimer = 0.5f;
    }

    public void ReachDelay()
    {
        reachTool.SetActive(true);
    }
}
