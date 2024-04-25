using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ScenarioScript : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene("Main Level");
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main Menu");
    }
}
