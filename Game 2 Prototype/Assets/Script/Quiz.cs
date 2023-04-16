using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    public GameObject Hati_Ireng1;
    public GameObject Hati_Ireng2;
    public GameObject Hati_Ireng3;

    public int maxhealth = 3;
    private int currenthealth;

    private int Tamat_PS = 0;
    private int Tamat_NES = 0;
    private int Tamat_GB = 0;
    private int Tamat_TTR = 0;
    private int Tamat_PCM = 0;
    private int Tamat_MAR = 0;
    private int Tamat_SON = 0;
    private int Tamat_POK = 0;
    private int Tamat_TAX = 0;

    void Start()
    {
        currenthealth = maxhealth;
    }

    public void Choose_correct_PS()
    {
        correct_PS1.SetActive(true);
        close_black_PS1.SetActive(false);
        Quiz_Canvas_PS1.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_PS = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_PS()
    {
        correct_PS1.SetActive(false);
        close_black_PS1.SetActive(true);
        Quiz_Canvas_PS1.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_NES()
    {
        correct_NES.SetActive(true);
        close_black_NES.SetActive(false);
        Quiz_Canvas_NES.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_NES = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_NES()
    {
        correct_NES.SetActive(false);
        close_black_NES.SetActive(true);
        Quiz_Canvas_NES.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_GB()
    {
        correct_GB.SetActive(true);
        close_black_GB.SetActive(false);
        Quiz_Canvas_GB.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_GB = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_GB()
    {
        correct_GB.SetActive(false);
        close_black_GB.SetActive(true);
        Quiz_Canvas_GB.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_TTR()
    {
        correct_TTR.SetActive(true);
        close_black_TTR.SetActive(false);
        Quiz_Canvas_TTR.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_TTR = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_TTR()
    {
        correct_TTR.SetActive(false);
        close_black_TTR.SetActive(true);
        Quiz_Canvas_TTR.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_PCM()
    {
        correct_PCM.SetActive(true);
        close_black_PCM.SetActive(false);
        Quiz_Canvas_PCM.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_PCM = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_PCM()
    {
        correct_PCM.SetActive(false);
        close_black_PCM.SetActive(true);
        Quiz_Canvas_PCM.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_MAR()
    {
        correct_MAR.SetActive(true);
        close_black_MAR.SetActive(false);
        Quiz_Canvas_MAR.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_MAR = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_MAR()
    {
        correct_MAR.SetActive(false);
        close_black_MAR.SetActive(true);
        Quiz_Canvas_MAR.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_POK()
    {
        correct_POK.SetActive(true);
        close_black_POK.SetActive(false);
        Quiz_Canvas_POK.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_POK = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_POK()
    {
        correct_POK.SetActive(false);
        close_black_POK.SetActive(true);
        Quiz_Canvas_POK.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_SON()
    {
        correct_SON.SetActive(true);
        close_black_SON.SetActive(false);
        Quiz_Canvas_SON.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_SON = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_SON()
    {
        correct_SON.SetActive(false);
        close_black_SON.SetActive(true);
        Quiz_Canvas_SON.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void Choose_correct_TAX()
    {
        correct_TAX.SetActive(true);
        close_black_TAX.SetActive(false);
        Quiz_Canvas_TAX.SetActive(false);
        GameObject.Find("Jawab_Benar").GetComponent<AudioSource>().Play();
        Tamat_TAX = 1;
        Tamat();
        Time.timeScale = 1f;
    }

    public void Choose_wrong_TAX()
    {
        correct_TAX.SetActive(false);
        close_black_TAX.SetActive(true);
        Quiz_Canvas_TAX.SetActive(true);
        currenthealth = currenthealth - 1;
        if (currenthealth == 2)
        {
            Hati_Ireng1.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 1)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
        }
        if (currenthealth == 0)
        {
            Hati_Ireng1.SetActive(true);
            Hati_Ireng2.SetActive(true);
            Hati_Ireng3.SetActive(true);
            GameObject.Find("Jawab_Salah").GetComponent<AudioSource>().Play();
            GameObject.Find("Audio_BG").GetComponent<AudioSource>().Stop();
            GameOver();
        }
        Time.timeScale = 1f;
    }

    public void GameOver()
    {
        SceneManager.LoadScene("MainMenu");
    }

    public void Tamat()
    {
        if(Tamat_PS == 1 && Tamat_NES == 1 && Tamat_GB == 1 && Tamat_TTR == 1 && Tamat_PCM == 1 && Tamat_MAR == 1 && Tamat_SON == 1 && Tamat_POK == 1 && Tamat_TAX == 1)
        {
            SceneManager.LoadScene("MainMenu");
        }
    }
}
