using System.Collections;
using System.Collections.Generic;
using System.Data;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class RankSceneManager : MonoBehaviour
{
    public Sprite[] characterImages;
    public Image image1;
    public Image image2;
    public Image image3;

    public Text rank1Score;
    public Text rank2Score;
    public Text rank3Score;

    private void Awake()
    {
        rank1Score = rank1Score.GetComponent<Text>();
        rank2Score = rank2Score.GetComponent<Text>();
        rank3Score = rank3Score.GetComponent<Text>();
    }

    private void Start()
    {
        image1.sprite = characterImages[DataManager.ImageNum[1]];
        if (DataManager.Score[1] == 0) rank1Score.text = "none";
        else rank1Score.text = $"{(int)DataManager.Score[1]}";
        
        image2.sprite = characterImages[DataManager.ImageNum[2]];
        if (DataManager.Score[2] == 0) rank2Score.text = "none";
        else rank2Score.text = $"{(int)DataManager.Score[2]}";

        image3.sprite = characterImages[DataManager.ImageNum[3]];
        if (DataManager.Score[3] == 0) rank3Score.text = "none";
        else rank3Score.text = $"{(int)DataManager.Score[3]}";
    }
}
