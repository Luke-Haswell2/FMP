using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    [SerializeField] AudioMixer mixer;
    [SerializeField] Slider sfxSlider;

    public string MIXER_SFX = "SFXVolume";

    public Toggle sfxtoggle;

    void Awake()
    {
        sfxSlider.onValueChanged.AddListener(SetVolumeSFX);
    }
    void Update()
    {

    }

    public void SetVolumeSFX(float volume)
    {
        sfxSlider.value = volume;

        mixer.SetFloat(MIXER_SFX, volume);
    }
    public void ToggleSFX(int logic)
    {
        if (sfxtoggle.isOn == true)
        {
            logic = 1;
            sfxSlider.interactable = true;
            SetVolumeSFX(0f);
        }
        else if (sfxtoggle.isOn == false)
        {
            logic = 0;
            sfxSlider.interactable = false;
            SetVolumeSFX(-80);
        }
    }

    public void LoadGame()
    {
        SceneManager.LoadScene("Main Level");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
