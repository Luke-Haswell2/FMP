using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ScenarioLoaderMenu : MonoBehaviour
{

    public void LoadAlpha()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenario Alpha");
        print("Scene load alpha");
    }
    public void LoadBravo()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenario Bravo");
        print("Scene load bravo");
    }
    public void LoadCharlie()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenario Charlie");
        print("Scene load charlie");
    }
    public void LoadDelta()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("Scenario Delta");
        print("Scene load delta");
    }
    public void Resume()
    {
        Time.timeScale = 1f;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
