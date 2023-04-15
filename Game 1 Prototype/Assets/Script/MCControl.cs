using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MCControl : MonoBehaviour
{
    private Rigidbody2D rb;
    private Animator anim;
    private int MoveSpeed, Jump;
    private bool MoveRight;
    int sceneIndex, levelPassed;

    [SerializeField]
    GameObject GameOverMenu, WinMenu, MC;

    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        MoveSpeed = 3;
        Jump = 4;
        StartCoroutine(Right());
        sceneIndex = SceneManager.GetActiveScene().buildIndex;
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
    }

    public void jump()
    {
        GameObject.Find("Jump").GetComponent<AudioSource>().Play();
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
            transform.Translate(Vector2.right * Time.deltaTime * MoveSpeed);
            anim.SetBool("MC_Run",true);
        }
    }

    private IEnumerator OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Enemy")
        {
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
            GameObject.Find("BG In Game").GetComponent<AudioSource>().Stop();
            GameObject.Find("Sfx Lose").GetComponent<AudioSource>().Play();
        }


        if(col.tag == "Finish")
        {
            GameObject.Find("BG In Game").GetComponent<AudioSource>().Stop();
            GameObject.Find("Portal").GetComponent<AudioSource>().Play();
            Debug.Log("tes1");
            Debug.Log("test2"); 
            yield return new WaitForSeconds(1f);  
            MC.SetActive(false); 
            Debug.Log("test3");
            WinMenu.SetActive(true);
            GameObject.Find("Sfx Win").GetComponent<AudioSource>().Play();
            Time.timeScale = 0f;
            PlayerPrefs.SetInt("LevelPassed", sceneIndex-3);
        }

    
    }

    
}
