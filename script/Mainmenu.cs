using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mainmenu : MonoBehaviour
{
  public void PlayGame()  //To play or to load a scene
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);

        FindObjectOfType<audiomanager>().Play("Play fx");
    }

    public void QuitGame()     //To quit the game'
    {
        Debug.Log("Quit!!");
        Application.Quit();

        FindObjectOfType<audiomanager>().Play("M menu fx");
    }
}
