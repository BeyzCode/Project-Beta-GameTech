using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    [SerializeField]
    GameObject pausee;

    public void pause()
    {
        pausee.SetActive(true);
        Time.timeScale = 0f;
    }

    public void resume()
    {
        pausee.SetActive(false);
        Time.timeScale = 1f;
    }

    public void sound()
   {
    GameObject.Find("Sfx Click button").GetComponent<AudioSource>().Play();
   }

    public void home()
    {
        SceneManager.LoadScene("MainMenu");
        Time.timeScale = 1f;
    }
}
