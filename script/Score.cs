using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Transform player;
    public Text scoretext;

    // Update is called once per frame
    void Update()
    {
        scoretext.text = player.position.z.ToString("0m"); // The code is for the distance text.
    }
}
