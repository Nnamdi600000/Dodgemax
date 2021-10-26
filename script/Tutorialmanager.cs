using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorialmanager : MonoBehaviour
{
    public playermovement playermovement;
    public GameObject[] popup;
    private int popupIndex;
    // Start is called before the first frame update
    void Start()
    {
        playermovement.forwardforce = 0f;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < popup.Length; i++)
        {
            if(i == popupIndex)
            {
               popup[i].SetActive(true);
            }else
            {
                popup[i].SetActive(false);
                 playermovement.forwardforce = 18300f;
            }
        }
        if(popupIndex == 0)
        {
           if(Input.GetMouseButton(0))
           {
              popupIndex++;
           }
        }
    }
}
