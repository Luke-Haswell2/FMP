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
    }

    void NotebookActive()
    {
        //notebookUI.SetActive(true);
        page1.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
