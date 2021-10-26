using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndTrigger : MonoBehaviour {

    public Gamemanager gameManager;

    private void OnTriggerEnter()
    {
        gameManager.completelevel();
        gameManager.Winlevel();
    }

}
