using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StoryScript : MonoBehaviour
{
    public GameObject Scene1;
    public GameObject Scene2;
    public GameObject Scene3;
    public GameObject Scene4;

    public void Scene2_Play()
    {
        Scene1.SetActive(false);
        Scene2.SetActive(true);
    }
    public void Scene3_Play()
    {
        Scene2.SetActive(false);
        Scene3.SetActive(true);
    }
    public void Scene4_Play()
    {
        Scene3.SetActive(false);
        Scene4.SetActive(true);
    }
    public void B2Menu()
    {
        SceneManager.LoadScene("MainMenu");
    }
    
    public void sound()
   {
    GameObject.Find("Sfx Click button").GetComponent<AudioSource>().Play();
   }
}
