using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;

[RequireComponent(typeof(Rigidbody2D))]
/// <summary>
/// Class used to simulate 2D Physicss
/// </summary>
public class PhysicsObject : MonoBehaviour
{
    public float gravityModifier = 1f;
    protected Rigidbody2D rb2d;
    protected Vector2 velocity;

    void OnEnable()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Assert.IsNotNull(rb2d);
    }

    void FixedUpdate()
    {
        velocity += gravityModifier * Physics2D.gravity * Time.deltaTime;
        Vector2 deltaPosition = velocity * Time.deltaTime;
        Vector2 move = Vector2.up * deltaPosition.y;
        Movement(move);
    }

    void Movement(Vector2 move)
    {
        rb2d.position = rb2d.position + move;
    }
}
