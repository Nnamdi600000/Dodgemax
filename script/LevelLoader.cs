using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelLoader : MonoBehaviour
{
    public Animator transition;

    public float transitionTime;

    // Update is called once per frame
    void Update()
    {
       /* if (Input.GetMouseButtonDown(0))
        {
            LoadNextLevel();
        }*/
    }

   /* public void LoadNextLevel()
    {

       StartCoroutine(LoadLevel(SceneManager.GetActiveScene().buildIndex + 1));

    }*/

    IEnumerator LoadLevel(int levelindex)
    {
        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        //SceneManager.LoadScene(levelindex);
    }
}
