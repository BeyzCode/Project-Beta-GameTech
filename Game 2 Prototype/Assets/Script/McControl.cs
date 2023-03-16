using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class McControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private SpriteRenderer spi;
    private int MoveSpeed;
    private bool MoveRight, MoveLeft, MoveUp, MoveDown;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spi = GetComponent<SpriteRenderer>();
        MoveSpeed = 2;
        MoveRight = false;
        MoveLeft = false;
        MoveUp = false;
        MoveDown = false;
    }

    public void right()
    {
        MoveRight = true;
    }

    public void left()
    {
        MoveLeft = true;
    }

    public void up()
    {
        MoveUp = true;
    }

    public void down()
    {
        MoveDown = true;
    }

    public void stop()
    {
        MoveRight = false;
        MoveLeft = false;
        MoveUp = false;
        MoveDown = false;
    }

    void Update()
    {
        if(MoveRight)
        {
            rb.velocity = new Vector3(MoveSpeed,0,0);
            spi.flipX = true;
        }

        if(MoveLeft)
        {
            rb.velocity = new Vector3(-MoveSpeed,0,0);
            spi.flipX = false;
        }

        if(MoveUp)
        {
            rb.velocity = new Vector3(0,MoveSpeed,0);
        }

        if(MoveDown)
        {
            rb.velocity = new Vector3(0,-MoveSpeed,0);
        }
    }
}
