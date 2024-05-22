using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class QuitGameButton : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clip;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void TouchQuitGameButton()
    {
        audioSource.PlayOneShot(clip);
        Invoke("QuitGame", 0.5f);
    }
    public void QuitGame()
    {
        #if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;
        #else
        Application.Quit();
        #endif
    }
}
