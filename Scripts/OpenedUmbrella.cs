using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenedUmbrella : MonoBehaviour
{
    [SerializeField] Text shieldTxt;
    Collider2D collider;
    int shieldTimes;
    private void Start()
    {
        collider = gameObject.GetComponent<Collider2D>();
        shieldTimes = Random.Range(1, 6);
    }
    private void Update()
    {
        Vector2 playerPosition = GameObject.FindWithTag("Player").transform.position;
        gameObject.transform.position = new Vector2(playerPosition.x, playerPosition.y+1);
        shieldTxt.text = shieldTimes.ToString();
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        shieldTimes--;
        if(shieldTimes == 0)
        {
            Destroy(gameObject);
        }
    }
    public void AddShield()
    {
        shieldTimes += Random.Range(1, 6);
    }


}
