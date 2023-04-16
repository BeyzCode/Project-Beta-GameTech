using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        GameObject.Find("Audio_MainMenu").GetComponent<AudioSource>().Stop();
        SceneManager.LoadScene("scene2");
        Time.timeScale = 1f;
    }

    public void Exit()
    {
        Application.Quit();
        GameObject.Find("Audio_MainMenu").GetComponent<AudioSource>().Stop();
        Debug.Log("Game Ended");
    }
}
