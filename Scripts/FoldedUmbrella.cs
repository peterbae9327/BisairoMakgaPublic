using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoldedUmbrella : MonoBehaviour
{
    Collider2D collider2D;
    Rigidbody2D rb2d;
    [SerializeField] GameObject Umbrella;
    private void Awake()
    {
        collider2D = gameObject.GetComponent<Collider2D>();
        rb2d = gameObject.GetComponent<Rigidbody2D>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player") && GameObject.FindWithTag("Umbrella") == null)
        {
            SummonUmbrella();
        }
        else if (other.CompareTag("Player") && GameObject.FindWithTag("Umbrella") != null)
        {
            GameObject.FindWithTag("Umbrella").GetComponent<OpenedUmbrella>().AddShield();
        }
        else return;
        Destroy(gameObject);
    }

    private void SummonUmbrella()
    {
        Instantiate(Umbrella);
    }
}
