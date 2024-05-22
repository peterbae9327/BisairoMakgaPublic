using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainSceneManager : MonoBehaviour
{

    [SerializeField] private Text TimeTxt;

    public float score;
    [SerializeField]private int estimated = 10;
    public static MainSceneManager sceneManager;
    private GameObject rainMaker;


    private void Awake()
    {
        if(sceneManager == null)
        {
            sceneManager = this;
        }
        rainMaker = GameObject.Find("RainMaker");

        CharacterDataManager.instance.CreateCharacter();
    }

    private void Update()
    {
        score += Time.deltaTime;
        TimeTxt.text = $"Score : {(int)score}";
        if(estimated < score)
        {
            estimated += 10;
            rainMaker.GetComponent<MakeRain>().LevelUp();
        }
        Data.instance.score = score;
    }
    public void InitializeScore()
    {
        score = 0;
    }

    public void AddScore()
    {
        score++;
    }


}
