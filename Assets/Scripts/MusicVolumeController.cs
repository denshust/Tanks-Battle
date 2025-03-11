using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicVolumeController : MonoBehaviour
{
    private void Start()
    {
        GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat("volume", 1);
    }
}
