using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class action : MonoBehaviour
{
    public GameObject Button2_Canvas;
    public GameObject Button3_Canvas;
    public GameObject Interact;
    public GameObject Quiz_Canvas;

    public void aksi()
    {
        Interact.SetActive(true);
        Time.timeScale = 1f;
    }

    public void aksi_2()
    {
        Quiz_Canvas.SetActive(true);
        Time.timeScale = 1f;
    }

    public void close_aksi_2()
    {
        Quiz_Canvas.SetActive(false);
        Time.timeScale = 1f;
    }

    public void close_aksi()
    {
        Interact.SetActive(false);
        Time.timeScale = 1f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Item")
        {
            Button2_Canvas.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black")
        {
            Button3_Canvas.SetActive(true);
            Time.timeScale = 1f;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Item")
        { 
            Button2_Canvas.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black")
        {
            Button3_Canvas.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
