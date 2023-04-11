using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private int MoveSpeed, Jump;
    private bool MoveRight;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        MoveSpeed = 4;
        Jump = 8;
        StartCoroutine(Right());
    }

    public void jump()
    {
        StartCoroutine(JUMP());
    }

    IEnumerator JUMP()
    {
        yield return new WaitForSeconds(0.2f);
        rb.velocity = new Vector2(0, Jump);
    }

    IEnumerator Right()
    {
        yield return new WaitForSeconds(2f);
        MoveRight = true;
    }

    public void Update()
    {
        if(MoveRight)
        {
            transform.Translate(Vector2.right * Time.deltaTime * MoveSpeed);
            anim.SetBool("Enemy_Run",true);
        }
    }

    // private void OnTriggerEnter2D(Collider2D col)
    // {
    //     if(col.tag == "Enemy")
    //     {
    //         GameOverMenu.SetActive(true);
    //         Time.timeScale = 0f;
    //     }
    // }
}
