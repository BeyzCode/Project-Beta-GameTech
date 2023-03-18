using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public GameObject correct;
    public GameObject close_black;
    public GameObject Quiz_Canvas;

    public void Choose_correct()
    {
        correct.SetActive(true);
        close_black.SetActive(false);
        Quiz_Canvas.SetActive(false);
        Time.timeScale = 1f;
    }
}
