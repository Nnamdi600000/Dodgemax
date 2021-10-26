using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triggersfx : MonoBehaviour
{
    public AudioSource Playsource;

    void OnTriggerEnter(Collider other)
    {
        Playsource.Play();
    }
}
