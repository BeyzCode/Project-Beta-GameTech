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
    public GameObject Player, Enemy;
    public float speed;

    private float distance;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        //MoveSpeed = 3;
        Jump = 5;
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
        yield return new WaitForSeconds(1.5f);
        MoveRight = true;
    }

    public void Update()
    {
        if(MoveRight)
        {
            distance = Vector2.Distance(transform.position, Player.transform.position);
            Vector2 direction = Player.transform.position - transform.position;
            transform.position = Vector2.MoveTowards(this.transform.position, Player.transform.position, speed * Time.deltaTime);
            anim.SetBool("Enemy_Run",true);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Finish")
        {
            Enemy.SetActive(false);
        }
    }
}
