using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
   public void play()
   {
    SceneManager.LoadScene("LevelMenu");
   }

   public void sound()
   {
    GameObject.Find("Sfx Click button").GetComponent<AudioSource>().Play();
   }

   public void exit()
   {
    Application.Quit();
    Debug.Log("Game Ended");
   }

   public void Story_Play()
   {
      SceneManager.LoadScene("Story");
   }
}
