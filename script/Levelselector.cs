using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Levelselector : MonoBehaviour
{
    public Button[] levelButtons; // the code contains all the levels buttons
    int levelPassed;
    void Start()
    {
        // This code is for the game to start its default level at one and to disable levels. 
        int levelReached = PlayerPrefs.GetInt("levelReached", 1);
        for (int i = 0; i < levelButtons.Length; i++)
        {
            if (i + 1 > levelReached)
            {
                 levelButtons[i].interactable = false;
            }
           
        }
    }
     
     // this methods are for loading up scenes of each levels.
    public void Level1()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void Level2()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Level3()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void Level4()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 4);
    }

    public void Level5()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 5);
    }

    public void Level6()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 6);
    }

    public void Level7()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 7);
    }

    public void Level8()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 8);
    }

    public void Level9()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 9);
    }

    public void Level10()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 10);
    }
}
