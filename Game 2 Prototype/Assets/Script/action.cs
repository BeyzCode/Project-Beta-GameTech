using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class action : MonoBehaviour
{
    public GameObject ButtonQZ_Canvas_PS1;
    public GameObject ButtonQZ_Canvas_NES;
    public GameObject ButtonQZ_Canvas_GB;
    public GameObject ButtonQZ_Canvas_TTR;
    public GameObject ButtonQZ_Canvas_PCM;
    public GameObject ButtonQZ_Canvas_MAR;
    public GameObject ButtonQZ_Canvas_POK;
    public GameObject ButtonQZ_Canvas_SON;
    public GameObject ButtonQZ_Canvas_TAX;

    public GameObject ButtonAN_Canvas_PS1;
    public GameObject ButtonAN_Canvas_NES;
    public GameObject ButtonAN_Canvas_GB;
    public GameObject ButtonAN_Canvas_TTR;
    public GameObject ButtonAN_Canvas_PCM;
    public GameObject ButtonAN_Canvas_MAR;
    public GameObject ButtonAN_Canvas_POK;
    public GameObject ButtonAN_Canvas_SON;
    public GameObject ButtonAN_Canvas_TAX;

    public GameObject Interact_PS1;
    public GameObject Interact_Atari;
    public GameObject Interact_GameBoy;
    public GameObject Interact_Tetris;
    public GameObject Interact_PacMan;
    public GameObject Interact_Mario;
    public GameObject Interact_Sonic;
    public GameObject Interact_Pokemon;
    public GameObject Interact_CrazyTaxi;

    public GameObject Quiz_PS1;
    public GameObject Quiz_Atari;
    public GameObject Quiz_GameBoy;
    public GameObject Quiz_Tetris;
    public GameObject Quiz_PacMan;
    public GameObject Quiz_Mario;
    public GameObject Quiz_Sonic;
    public GameObject Quiz_Pokemon;
    public GameObject Quiz_CrazyTaxi;

    //=========== aksi ===========
    public void aksi()
    {
        Interact_PS1.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_NES()
    {
        Interact_Atari.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_GB()
    {
        Interact_GameBoy.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_TTR()
    {
        Interact_Tetris.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_PCM()
    {
        Interact_PacMan.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_MAR()
    {
        Interact_Mario.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_POK()
    {
        Interact_Pokemon.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_SON()
    {
        Interact_Sonic.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_TAX()
    {
        Interact_CrazyTaxi.SetActive(true);
        Time.timeScale = 1f;
    }

    //=========== aksi 2 ===========
    public void aksi_2()
    {
        Quiz_PS1.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_NES()
    {
        Quiz_Atari.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_GB()
    {
        Quiz_GameBoy.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_TTR()
    {
        Quiz_Tetris.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_PCM()
    {
        Quiz_PacMan.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_MAR()
    {
        Quiz_Mario.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_POK()
    {
        Quiz_Pokemon.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_SON()
    {
        Quiz_Sonic.SetActive(true);
        Time.timeScale = 1f;
    }
    public void aksi_2_TAX()
    {
        Quiz_CrazyTaxi.SetActive(true);
        Time.timeScale = 1f;
    }

    //=========== Close aksi 2 ===========
    public void close_aksi_2()
    {
        Quiz_PS1.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_NES()
    {
        Quiz_Atari.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_GB()
    {
        Quiz_GameBoy.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_TTR()
    {
        Quiz_Tetris.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_PCM()
    {
        Quiz_PacMan.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_MAR()
    {
        Quiz_Mario.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_POK()
    {
        Quiz_Pokemon.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_SON()
    {
        Quiz_Sonic.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_2_TAX()
    {
        Quiz_CrazyTaxi.SetActive(false);
        Time.timeScale = 1f;
    }

    //=========== Close aksi ===========
    public void close_aksi()
    {
        Interact_PS1.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_NES()
    {
        Interact_Atari.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_GB()
    {
        Interact_GameBoy.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_TTR()
    {
        Interact_Tetris.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_PCM()
    {
        Interact_PacMan.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_MAR()
    {
        Interact_Mario.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_POK()
    {
        Interact_Pokemon.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_SON()
    {
        Interact_Sonic.SetActive(false);
        Time.timeScale = 1f;
    }
    public void close_aksi_TAX()
    {
        Interact_CrazyTaxi.SetActive(false);
        Time.timeScale = 1f;
    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Item")
        {
            ButtonQZ_Canvas_PS1.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Atari")
        {
            ButtonQZ_Canvas_NES.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_GameBoy")
        {
            ButtonQZ_Canvas_GB.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Sonic")
        {
            ButtonQZ_Canvas_SON.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Mario")
        {
            ButtonQZ_Canvas_MAR.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_PacMan")
        {
            ButtonQZ_Canvas_PCM.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Tetris")
        {
            ButtonQZ_Canvas_TTR.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Pokemon")
        {
            ButtonQZ_Canvas_POK.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_CrazyTaxi")
        {
            ButtonQZ_Canvas_TAX.SetActive(true);
            Time.timeScale = 1f;
        }

        if(col.tag == "Black")
        {
            ButtonAN_Canvas_PS1.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Atari")
        {
            ButtonAN_Canvas_NES.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_GameBoy")
        {
            ButtonAN_Canvas_GB.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Sonic")
        {
            ButtonAN_Canvas_SON.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Mario")
        {
            ButtonAN_Canvas_MAR.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_PackMan")
        {
            ButtonAN_Canvas_PCM.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Tetris")
        {
            ButtonAN_Canvas_TTR.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Pokemon")
        {
            ButtonAN_Canvas_POK.SetActive(true);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_CrazyTaxi")
        {
            ButtonAN_Canvas_TAX.SetActive(true);
            Time.timeScale = 1f;
        }
    }

    void OnTriggerExit2D(Collider2D col)
    {
        if(col.tag == "Item")
        { 
            ButtonQZ_Canvas_PS1.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Atari")
        {
            ButtonQZ_Canvas_NES.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_GameBoy")
        {
            ButtonQZ_Canvas_GB.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Sonic")
        {
            ButtonQZ_Canvas_SON.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Mario")
        {
            ButtonQZ_Canvas_MAR.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_PacMan")
        {
            ButtonQZ_Canvas_PCM.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Tetris")
        {
            ButtonQZ_Canvas_TTR.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_Pokemon")
        {
            ButtonQZ_Canvas_POK.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Item_CrazyTaxi")
        {
            ButtonQZ_Canvas_TAX.SetActive(false);
            Time.timeScale = 1f;
        }

        if(col.tag == "Black")
        {
            ButtonAN_Canvas_PS1.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Atari")
        {
            ButtonAN_Canvas_NES.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_GameBoy")
        {
            ButtonAN_Canvas_GB.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Sonic")
        {
            ButtonAN_Canvas_SON.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Mario")
        {
            ButtonAN_Canvas_MAR.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_PackMan")
        {
            ButtonAN_Canvas_PCM.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Tetris")
        {
            ButtonAN_Canvas_TTR.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_Pokemon")
        {
            ButtonAN_Canvas_POK.SetActive(false);
            Time.timeScale = 1f;
        }
        if(col.tag == "Black_CrazyTaxi")
        {
            ButtonAN_Canvas_TAX.SetActive(false);
            Time.timeScale = 1f;
        }
    }
}
