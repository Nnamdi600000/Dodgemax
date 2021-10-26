using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CreditUI : MonoBehaviour
{
    // for the CreditUI buttons
   public void menu()
    {
        SceneManager.LoadScene("Main menu");
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
