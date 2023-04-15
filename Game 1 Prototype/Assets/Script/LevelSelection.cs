using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelSelection : MonoBehaviour
{
    public Button lvl01Button, lvl02Button, lvl03Button, lvl04Button, lvl05Button;
    int levelPassed;

    // Start is called before the first frame update
    void Start()
    {
        levelPassed = PlayerPrefs.GetInt("LevelPassed");
        lvl02Button.interactable = false;
        lvl03Button.interactable = false;
        lvl04Button.interactable = false;
        lvl05Button.interactable = false;

        if(levelPassed == 1)
        {
            lvl02Button.interactable = true;
        }
        else if(levelPassed ==2)
        {
            lvl02Button.interactable = true;
            lvl03Button.interactable = true;
        }
        else if(levelPassed ==3)
        {
            lvl02Button.interactable = true;
            lvl03Button.interactable = true;
            lvl04Button.interactable = true;
        }
        else if(levelPassed >=4)
        {
            lvl02Button.interactable = true;
            lvl03Button.interactable = true;
            lvl04Button.interactable = true;
            lvl05Button.interactable = true;
        }
    }

    public void levelToload(int level)
    {
        SceneManager.LoadScene(level);
    }

    public void resetPP()
    {
        lvl02Button.interactable = false;
        lvl03Button.interactable = false;
        lvl04Button.interactable = false;
        lvl05Button.interactable = false;
        PlayerPrefs.DeleteAll();
    }

    public void sound()
   {
    GameObject.Find("Sfx Click button").GetComponent<AudioSource>().Play();
   }
}
