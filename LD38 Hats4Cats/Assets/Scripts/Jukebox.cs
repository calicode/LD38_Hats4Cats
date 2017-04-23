﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Jukebox : MonoBehaviour
{

    public AudioClip[] bgMusicArray;
    AudioSource audioSource;

    void Awake()
    {
        DontDestroyOnLoad(gameObject);


    }
    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefs_Manager.GetMasterVolume();
    }

    public void SetVolume(float volume)
    {
        if (volume > 0f && volume < 1f)
        {
            audioSource.volume = volume;
        }
        else { Debug.LogError("Tried to set volume too high. Input is " + volume); }

    }

    void OnLevelWasLoaded(int level)
    {
        PlayMusicTrack(level);
    }

    ///<summary> Plays the current music track and loops it </summary>


    public void PlayMusicTrack(int levelIndex)
    {

        if (levelIndex > bgMusicArray.Length) { return; }

        AudioClip clip = bgMusicArray[levelIndex];

        if (clip)
        {
            audioSource.clip = clip;
            audioSource.Play();
            audioSource.loop = true;
        }
        else { Debug.Log("No music clip for index " + levelIndex.ToString()); }



    }










}
