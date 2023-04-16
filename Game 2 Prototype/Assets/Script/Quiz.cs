using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quiz : MonoBehaviour
{
    public GameObject correct_PS1;
    public GameObject correct_NES;
    public GameObject correct_GB;
    public GameObject correct_TTR;
    public GameObject correct_PCM;
    public GameObject correct_MAR;
    public GameObject correct_SON;
    public GameObject correct_POK;
    public GameObject correct_TAX;

    public GameObject close_black_PS1;
    public GameObject close_black_NES;
    public GameObject close_black_GB;
    public GameObject close_black_TTR;
    public GameObject close_black_PCM;
    public GameObject close_black_MAR;
    public GameObject close_black_SON;
    public GameObject close_black_POK;
    public GameObject close_black_TAX;

    public GameObject Quiz_Canvas_PS1;
    public GameObject Quiz_Canvas_NES;
    public GameObject Quiz_Canvas_GB;
    public GameObject Quiz_Canvas_TTR;
    public GameObject Quiz_Canvas_PCM;
    public GameObject Quiz_Canvas_MAR;
    public GameObject Quiz_Canvas_SON;
    public GameObject Quiz_Canvas_POK;
    public GameObject Quiz_Canvas_TAX;


    public void Choose_correct_PS()
    {
        correct_PS1.SetActive(true);
        close_black_PS1.SetActive(false);
        Quiz_Canvas_PS1.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_NES()
    {
        correct_NES.SetActive(true);
        close_black_NES.SetActive(false);
        Quiz_Canvas_NES.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_GB()
    {
        correct_GB.SetActive(true);
        close_black_GB.SetActive(false);
        Quiz_Canvas_GB.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_TTR()
    {
        correct_TTR.SetActive(true);
        close_black_TTR.SetActive(false);
        Quiz_Canvas_TTR.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_PCM()
    {
        correct_PCM.SetActive(true);
        close_black_PCM.SetActive(false);
        Quiz_Canvas_PCM.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_MAR()
    {
        correct_MAR.SetActive(true);
        close_black_MAR.SetActive(false);
        Quiz_Canvas_MAR.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_POK()
    {
        correct_POK.SetActive(true);
        close_black_POK.SetActive(false);
        Quiz_Canvas_POK.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_SON()
    {
        correct_SON.SetActive(true);
        close_black_SON.SetActive(false);
        Quiz_Canvas_SON.SetActive(false);
        Time.timeScale = 1f;
    }

    public void Choose_correct_TAX()
    {
        correct_TAX.SetActive(true);
        close_black_TAX.SetActive(false);
        Quiz_Canvas_TAX.SetActive(false);
        Time.timeScale = 1f;
    }
}
