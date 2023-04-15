using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rocketcontrol : MonoBehaviour
{
    private int MoveSpeed;
    private bool MoveLeft;

    void Start()
    {
        Time.timeScale = 1f;
        MoveSpeed = 6;
        MoveLeft = true;
    }

    public void Update()
    {
        if(MoveLeft)
        {
            transform.Translate(Vector2.left * Time.deltaTime * MoveSpeed);
        }
    }
}
