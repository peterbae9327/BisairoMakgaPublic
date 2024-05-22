using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioClip bgmusic;

    private void Start()
    {
        audioSource.clip = bgmusic;
        audioSource.Play();
    }
}
