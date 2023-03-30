using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MCControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private int MoveSpeed, Jump;
    private bool MoveRight;

    [SerializeField]
    GameObject GameOverMenu, WinMenu;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        MoveSpeed = 4;
        Jump = 8;
        StartCoroutine(Right());
    }

    public void jump()
    {
        rb.velocity = new Vector2(0, Jump);
    }

    IEnumerator Right()
    {
        yield return new WaitForSeconds(2f);
        //anim.Play("MC_Right", 0, 0.0f);
        MoveRight = true;
    }


    public void Update()
    {
        if(MoveRight)
        {
            transform.Translate(Vector2.right * Time.deltaTime * MoveSpeed);
            //anim.Play("MC_Right", 0, 0.0f);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        if(col.tag == "Finish")
        {
            WinMenu.SetActive(true);
            Time.timeScale = 0f;
        }
    }

    
}
