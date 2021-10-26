using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausemenu : MonoBehaviour
{
    public static bool GameIsPause = false;
    public GameObject PausemenuUI;
    public GameObject CanvasUI;
    public GameObject CrossFade;
    public GameObject PauseButton;
   // public float restartDelay = 0f;
   
     //To resume the game in the pausemenu
    public void Resume()
    {
        PausemenuUI.SetActive(false);
        Time.timeScale = 1f; //To unfreeze
        GameIsPause = false;
        CanvasUI.SetActive(true);
        PauseButton.SetActive(true);
        // CrossFade.SetActive(true);

        FindObjectOfType<audiomanager>().Play("Resume fx");

    }    
    // To pause the game in the pausemenu
    public void Pause()
    {
        PausemenuUI.SetActive(true);
        Time.timeScale = 0f;  // to freeze the game
        GameIsPause = true;
        CanvasUI.SetActive(false);
        CrossFade.SetActive(false);
        PauseButton.SetActive(false);

        FindObjectOfType<audiomanager>().Play("Pause fx");
    }
    public void LoadMenu()
    {
        //Debug.Log("load menu!!");
        Time.timeScale = 1f;
        SceneManager.LoadScene("Main menu");

        FindObjectOfType<audiomanager>().Play("Menu fx");

    }
    // To quit the game in the pausemenu
    public void QuitGame()
    {
        Debug.Log("quitGame!!");
        Application.Quit();

        FindObjectOfType<audiomanager>().Play("Quit fx");
        
    }
}
