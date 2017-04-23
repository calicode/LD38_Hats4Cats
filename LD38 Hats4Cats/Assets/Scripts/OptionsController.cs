using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsController : MonoBehaviour
{
    Slider volumeSlider;
    public LevelManager levelManager;

    private Jukebox jukebox;
    private AudioSource audioSource;
    void Start()
    {
        jukebox = GameObject.FindObjectOfType<Jukebox>();
        volumeSlider = GameObject.FindObjectOfType<Slider>();
        volumeSlider.value = PlayerPrefs_Manager.GetMasterVolume();
    }



    // get this out of update
    void Update()
    {
        jukebox.SetVolume(volumeSlider.value);
        PlayerPrefs_Manager.SetMasterVolume(volumeSlider.value);
    }

}
