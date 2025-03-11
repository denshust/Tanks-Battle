using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OptionsManager : MonoBehaviour
{
    public Slider volumeSlider;

    private void Start()
    {
        volumeSlider.value = PlayerPrefs.GetFloat("volume",1);
    }

    public void SaveVolume()
    {
        PlayerPrefs.SetFloat("volume", volumeSlider.value);
    }
}
