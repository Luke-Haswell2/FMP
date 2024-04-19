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
        if (PlayerPrefs.HasKey(MIXER_SFX))
        {
            ManualVolumeSet(PlayerPrefs.GetFloat(MIXER_SFX));
        }
    }

    public void SetVolumeSFX()
    {
        mixer.SetFloat(MIXER_SFX, sfxSlider.value);
        PlayerPrefs.SetFloat(MIXER_SFX, sfxSlider.value);
    }

    public void ManualVolumeSet(float volume)
    {
        sfxSlider.value = volume;

        mixer.SetFloat(MIXER_SFX, volume);
        PlayerPrefs.SetFloat(MIXER_SFX, volume);
    }

    public void ToggleSFX(int logic)
    {
        if (sfxtoggle.isOn == true)
        {
            logic = 1;
            sfxSlider.interactable = true;
            ManualVolumeSet(0f);
            PlayerPrefs.SetFloat(MIXER_SFX, sfxSlider.value);
        }
        else if (sfxtoggle.isOn == false)
        {
            logic = 0;
            sfxSlider.interactable = false;
            ManualVolumeSet(-80);
            PlayerPrefs.SetFloat(MIXER_SFX, sfxSlider.value);
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
