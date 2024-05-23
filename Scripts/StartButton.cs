using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    AudioSource audioSource;
    public AudioClip clip;
    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    public void TouchStartButton()
    {
        Data.instance.save = false;
        audioSource.PlayOneShot(clip);
        Invoke("LoadMainScene", 0.5f);
    }
    public void TouchMainButton()
    {
        CharacterDataManager.instance.characterNum = 0;
        Data.instance.num = 1;
        Data.instance.save = false;
        audioSource.PlayOneShot(clip);
        Invoke("LoadStartScene", 0.5f);
    }
    public void TouchRankButton()
    {
        audioSource.PlayOneShot(clip);
        Invoke("LoadRankScene", 0.5f);
    }
    public void TouchRankQuitbutton()
    {
        audioSource.PlayOneShot(clip);
        Invoke("LoadEndScene", 0.5f);
    }
    public void LoadMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }
    public void LoadRankScene()
    {
        SceneManager.LoadScene("RankScene");
    }
    public void LoadEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }
}
