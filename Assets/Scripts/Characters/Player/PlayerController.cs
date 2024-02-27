using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public PlayerInput input;
    public Rigidbody2D rb;
    public float moveSpeed = 1.8f;
    public int facingRight = 1;

    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        rb = GetComponent<Rigidbody2D>();
    }

    public void Start()
    {
        input.EnableGameplayInputs();
    }
    public void SetVelocity(float _xVelocity,float _yVelocity)
    {
        rb.velocity = new Vector2(_xVelocity, _yVelocity);
        if (_xVelocity < 0)
            facingRight = -1;
        else
            facingRight = 1;
    }
    public void SetZeroVelocity()
    {
        SetVelocity(0f,0f);
    }
    public void rotate()
    {
    }
}
