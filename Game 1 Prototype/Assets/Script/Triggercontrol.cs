using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Triggercontrol : MonoBehaviour
{
    public Transform RocketStation1, RocketStation2, RocketStation3;
    public GameObject RocketPrefab;
    private int MoveSpeed, Jump;
    private bool MoveRight;

    void Start()
    {
        Time.timeScale = 1f;
        MoveSpeed = 3;
        MoveRight = true;
        Jump = 4;

    }

    public void Update()
    {
        if(MoveRight)
        {
            transform.Translate(Vector2.right * Time.deltaTime * MoveSpeed);
            transform.Translate(Vector2.up * Time.deltaTime * Jump);
        }
    }

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "TriggerOn")
        {
            Instantiate(RocketPrefab, RocketStation1);
            Instantiate(RocketPrefab, RocketStation2);
            Instantiate(RocketPrefab, RocketStation3);
            Destroy(gameObject);
        }
    }
}
