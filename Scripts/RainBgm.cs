using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RainBgm : MonoBehaviour
{
    public static RainBgm rainBgm;

    AudioSource audioSource;
    public AudioClip rainClip;

    private void Awake()
    {
        if(rainBgm == null)
        {
            rainBgm = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        audioSource.clip = rainClip;
        audioSource.Play();
    }
}
