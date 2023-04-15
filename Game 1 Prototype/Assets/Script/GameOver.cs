using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    [SerializeField]
    GameObject GameOverMenu;

    public void retrylevel1()
    {
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("Level1");
        Time.timeScale = 1f;
    }

    public void retrylevel2()
    {
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;

    }

    public void retrylevel3()
    {
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;

    }

    public void retrylevel4()
    {
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1f;

    }

    public void retrylevel5()
    {
        GameOverMenu.SetActive(false);
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1f;

    }
}
