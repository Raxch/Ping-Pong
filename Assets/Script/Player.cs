using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
//using UnityEngine.WSA;

public class Player : MonoBehaviour
{
    public bool player1;
    public float speed;
    public Rigidbody2D rb;
    public Vector3 startPosition;

    private float movement;

    public void Start()
    {
        startPosition = transform.position;
    }
    public void Update()
    {
        if (player1)
        {
            movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            movement = Input.GetAxisRaw("Vertical2");
        }
        rb.velocity = new Vector2(rb.velocity.x, movement * speed);
    }

    public void Reset()
    {
        rb.velocity = Vector2.zero;
        transform.position = startPosition;
    }
}
