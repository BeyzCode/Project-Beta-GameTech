using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class WinSystem : MonoBehaviour
{
    [SerializeField]
    GameObject WinMenu;

    public void ToLevel2()
    {
        WinMenu.SetActive(false);
        SceneManager.LoadScene("Level2");
        Time.timeScale = 1f;
    }

    public void ToLevel3()
    {
        WinMenu.SetActive(false);
        SceneManager.LoadScene("Level3");
        Time.timeScale = 1f;
    }

    public void ToLevel4()
    {
        WinMenu.SetActive(false);
        SceneManager.LoadScene("Level4");
        Time.timeScale = 1f;
    }

    public void ToLevel5()
    {
        WinMenu.SetActive(false);
        SceneManager.LoadScene("Level5");
        Time.timeScale = 1f;
    }

    public void ToEnding()
    {
        WinMenu.SetActive(false);
        SceneManager.LoadScene("Ending");
        Time.timeScale = 1f;
    }

}
