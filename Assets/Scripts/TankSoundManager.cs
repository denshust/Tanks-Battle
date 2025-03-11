using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSoundManager : MonoBehaviour
{
    public AudioClip shootSound;
    public AudioClip moveSound;

    private AudioSource audioSource;

    public static TankSoundManager Instance;

    void Start()
    {
        Instance = this;
        audioSource = GetComponent<AudioSource>();
    }

    public void PlayShootSound()
    {
        audioSource.PlayOneShot(shootSound);
    }
    public void PlayMoveSound(bool play)
    {
        if (play)
        {
            audioSource.clip = moveSound;
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
