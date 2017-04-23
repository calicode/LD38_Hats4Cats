using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransitionToMainMenu : MonoBehaviour
{
    LevelManager levelManager;
    // Use this for initialization
    void Start()
    {

        Invoke("LoadMainMenu", 3f);
    }

    // Update is called once per frame
    void LoadMainMenu()
    {

        LevelManager.LoadLevel("00_Main Menu");
    }

}
