using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEditor.Tilemaps;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;

    // 실제 캐릭터의 움직임 구현
    BiMakCharacterController controller;

    Rigidbody2D rb;

    Vector2 movementDirection = Vector2.zero;
    public float speed = 5;

    private void Awake()
    {
        controller = GetComponent<BiMakCharacterController>();
        rb = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
        controller.OnMoveEvent += Move;
    }

    void Move(Vector2 direction)
    {
        movementDirection = direction;

        // 캐릭터가 왼쪽을 보고 있다는 가정
        if (direction.x > 0)
        {
            spriteRenderer.flipX = true; 
        }
        else if (direction.x < 0)
        {
            spriteRenderer.flipX = false;
        }
    }

    private void FixedUpdate()
    {
        ApplyMovement(movementDirection);
    }

    void ApplyMovement(Vector2 direction)
    {
        direction *= speed;
        rb.velocity = direction;
    }
}
