using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void Play()
    {
        SceneManager.LoadScene("scene1");
    }

    public void Exit()
    {
        Application.Quit();
        Debug.Log("Game Ended");
    }
}
