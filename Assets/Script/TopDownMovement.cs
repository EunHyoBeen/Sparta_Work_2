using System;
using UnityEngine;

public class TopDownMovement : MonoBehaviour
{
    private TopDownController controller;
    private Rigidbody2D rb;

    private Vector2 movementDirection = Vector2.zero;

    private void Awake()
    {
        controller = GetComponent<TopDownController>();
        rb = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void move(Vector2 vector)
    {
        throw new NotImplementedException();
    }

    private void FixedUpdate()
    {
        Applymovement(movementDirection);
    }

    private void Move(Vector2 direction)
    {
        movementDirection = direction;
    }

    private void Applymovement(Vector2 direction)
    {
        direction = direction * 5;
        rb.velocity = direction;
    }
}