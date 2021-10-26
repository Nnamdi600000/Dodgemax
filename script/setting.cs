using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setting : MonoBehaviour
{
    public Slider[] volumeSliders;
    public Toggle[] resolutionToggle;
    public int[] screenWidths;
    int activeScreenResIndex;

   public void SetScreenResolution(int i)
    {
      if (resolutionToggle [i].isOn)
        {
            float aspectRatio = 16 / 9f;
            Screen.SetResolution(screenWidths[i], (int)(screenWidths[i] / aspectRatio), false);
        }
    }
    public void SetFullscreen(bool isFullscreen)
    {
        for (int i = 0; i< resolutionToggle.Length; i++)
        {
            resolutionToggle[i].interactable = !isFullscreen;
        }
        if (isFullscreen)
        {
            Resolution[] allResolution = Screen.resolutions;
            Resolution maxResolution = allResolution[allResolution.Length - 1];
            Screen.SetResolution(maxResolution.width, maxResolution.height, true);
        }
        else
        {
            SetScreenResolution(activeScreenResIndex);
        }
    }
  
}
