using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class PauseMenu : MonoBehaviour
{
    public static bool GameIsPaused = false;

    public GameObject pauseMenuUI;

    public GameObject notebookUI1;
    public GameObject notebookUI2;
    public GameObject notebookUI3;
    public GameObject notebookUI4;
    public GameObject notebookUI5;

    public GameObject loaderUI1;
    public GameObject loaderUI2;
    public GameObject loaderUI3;
    public GameObject loaderUI4;

    public GameObject notebookPause;
    public GameObject loaderPause;

    public GameObject reachTool;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
    }

    public void Resume()
    {
        pauseMenuUI.SetActive(false);
        Time.timeScale = 1f;
        GameIsPaused = false;
        Cursor.lockState = CursorLockMode.Locked;

        notebookPause.SetActive(true);
        loaderPause.SetActive(true);

        reachTool.SetActive(true);
    }

    void Pause()
    {
        pauseMenuUI.SetActive(true);
        Time.timeScale = 0f;
        GameIsPaused = true;
        Cursor.lockState = CursorLockMode.None;

        notebookPause.SetActive(false);
        loaderPause.SetActive(false);

        notebookUI1.SetActive(false);
        notebookUI2.SetActive(false);
        notebookUI3.SetActive(false);
        notebookUI4.SetActive(false);
        notebookUI5.SetActive(false);

        loaderUI1.SetActive(false);
        loaderUI2.SetActive(false);
        loaderUI3.SetActive(false);
        loaderUI4.SetActive(false);

        reachTool.SetActive(false);
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main Menu");
    }
}
