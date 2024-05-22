using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReSetScore : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clip;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void TouchReSetButton()
    {
        PlayerPrefs.DeleteAll();
        audioSource.PlayOneShot(clip);
        Invoke("LoadStartScene", 0.5f);
    }
    void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
}
