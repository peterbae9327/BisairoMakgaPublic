using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RainDrop : MonoBehaviour
{
    Rigidbody2D rb2d;
    Animator animator;
    private GameObject mainSceneManager;
    [SerializeField] private GameObject foldedUmbrellaprefab;
    private void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
        mainSceneManager = GameObject.Find("MainSceneManager");
    }
    private void Update()
    {
        if (gameObject.transform.position.y <= -4.6)
        {
            rb2d.velocity = Vector2.zero;
            rb2d.gravityScale = 0;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        rb2d.velocity = Vector2.zero;
        rb2d.gravityScale = 0;
        animator.SetBool("OnGround", true);
        if (collision.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene("EndScene");
        }
        else if (collision.gameObject.CompareTag("Umbrella")) {}
        else
        {
            int i = Random.Range(0, 10);
            if(i == 0)
            {
                GameObject foldedumbrella = Instantiate(foldedUmbrellaprefab);
                foldedumbrella.transform.position = gameObject.transform.position;
            }
            mainSceneManager.GetComponent<MainSceneManager>().AddScore();
        }
        Destroy(transform.parent.gameObject, 0.15f);
    }
}
