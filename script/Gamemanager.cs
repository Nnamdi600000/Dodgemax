using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public GameObject completeLevelUI;
    public GameObject loseUI;
    public GameObject Button1;
    public GameObject Button2;
    public GameObject pauseButton;
    public GameObject ScoreUI;
    public GameObject DistanceUI;
    public GameObject trigger1Text;
    public GameObject player;
    public string nextLevel;
    public int levelToUnlock;

    public void completelevel() // function for the level complete UI.
    {
       completeLevelUI.SetActive(true);
        loseUI.SetActive(false);
        pauseButton.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        ScoreUI.SetActive(true);
        DistanceUI.SetActive(true);
        player.SetActive(false);
    }
    
    public void loseui() // function for the level loseUI.
    {
        loseUI.SetActive(true);
        completeLevelUI.SetActive(false);
        pauseButton.SetActive(false);
        Button1.SetActive(false);
        Button2.SetActive(false);
        ScoreUI.SetActive(true);
        DistanceUI.SetActive(true);
        trigger1Text.SetActive(false);
         player.SetActive(false);
    }

// To Unlock the levels
    public void Winlevel()
    {
       Debug.Log("Won level");
       PlayerPrefs.SetInt("levelReached", levelToUnlock);
    }
}
