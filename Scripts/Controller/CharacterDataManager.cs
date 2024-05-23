using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDataManager : MonoBehaviour
{
    public static CharacterDataManager instance;

    public int characterNum; //Ä³¸¯ÅÍ

    public GameObject[] characterPrefabs;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void SelectCharacter(int num)
    {
        CharacterDataManager.instance.characterNum = num;
    }

    public void CreateCharacter()
    {
        Instantiate(characterPrefabs[characterNum]);
    }
}
