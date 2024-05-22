using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
    public static float[] Score = new float[4];
    public static int[] ImageNum = new int[4];

    public static void ScoreSet(float curruntScore, int curruntImageNum)
    {
        PlayerPrefs.SetFloat("CurruntScore", curruntScore);
        PlayerPrefs.SetInt("CurruntImageNum", curruntImageNum);

        float score = 0f;
        int num = 0;

        for (int i = 1; i < 4; i++)
        {
            Score[i] = PlayerPrefs.GetFloat(i + "Score");
            ImageNum[i] = PlayerPrefs.GetInt(i + "Num");

            while (Score[i] < curruntScore)
            {
                score = Score[i];
                num = ImageNum[i];
                Score[i] = curruntScore;
                ImageNum[i] = curruntImageNum;

                PlayerPrefs.SetFloat(i + "Score", curruntScore);
                PlayerPrefs.SetInt(i + "Num", curruntImageNum);

                curruntScore = score;
                curruntImageNum = num;
            }
        }
        for (int i = 1; i < 4; i++)
        {
            PlayerPrefs.SetFloat(i + "Score", Score[i]);
            PlayerPrefs.SetInt(i + "Num", ImageNum[i]);
        }
    }
}
