using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;


public class EndPanelText : MonoBehaviour
{
    public Text rank;
    public Text score;
    public Text bestScore;

    MainSceneManager MainSceneManager;
    private void Awake()
    {
        rank = rank.GetComponent<Text>();
        score = score.GetComponent<Text>();
        bestScore = bestScore.GetComponent<Text>();
    }
    private void Start()
    {
        if (!Data.instance.save)
        {
            DataManager.ScoreSet(Data.instance.score, Data.instance.num);
            Data.instance.save = true;
        }
        PrintRank();
        PrintScore();
        PrintBestScore();
    }
    public void PrintRank()
    {
        if (Data.instance.score <= 20f)
        {
            rank.color = Color.black;
            rank.text = "F";
        }
        else if (Data.instance.score > 20f && Data.instance.score <= 40f)
        {
            rank.color = Color.gray;
            rank.text = "E";
        }
        else if (Data.instance.score > 40f && Data.instance.score <= 60f)
        {
            rank.color = Color.gray;
            rank.text = "D";
        }
        else if (Data.instance.score > 60f && Data.instance.score <= 80f)
        {
            rank.color = Color.blue;
            rank.text = "C";
        }
        else if (Data.instance.score > 80f && Data.instance.score <= 100f)
        {
            rank.color = Color.red;
            rank.text = "B";
        }
        else if (Data.instance.score > 100f && Data.instance.score <= 120f)
        {
            rank.color = Color.yellow;
            rank.text = "A";
        }
        else if (Data.instance.score > 120f)
        {
            rank.color = Color.cyan;
            rank.text = "S";
        }
    }
    public void PrintScore()
    {
        
        score.text = $"{(int)Data.instance.score}";
    }
    public void PrintBestScore()
    {
        bestScore.text = $"{(int)DataManager.Score[1]}";
    }
}
