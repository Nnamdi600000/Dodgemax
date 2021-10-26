using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class Settingmenu2 : MonoBehaviour
{
    public AudioMixer audioMixer2;

    public void SetVolume(float volume)
    {
        // Debug.Log(volume);
        audioMixer2.SetFloat("Newvolume", volume);
    }
}
