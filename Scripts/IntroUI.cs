using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class IntroUI : MonoBehaviour
{
    public TMP_InputField InputField;
    public Sprite[] characterImages;    // ĳ���� �̹��� ��������
    public Image selectedcharacter;

    public void ChoiceCharacter(int num)
    {
        if(characterImages != null && num >= 0 && num < characterImages.Length)
        {
            selectedcharacter.sprite = characterImages[num];
            Data.instance.num = num + 1;
        }
    }
}
