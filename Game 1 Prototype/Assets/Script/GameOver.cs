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
}
