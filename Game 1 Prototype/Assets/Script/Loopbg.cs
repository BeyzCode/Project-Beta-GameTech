using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loopbg : MonoBehaviour
{
    public Transform mainCam;
    public Transform firBG;
    public Transform secBG;
    public Transform thiBG;

    public float length;

    // Update is called once per frame
    void Update()
    {
        if(mainCam.position.x > thiBG.position.x)
        {
            firBG.position = thiBG.position + Vector3.right * length;
            secBG.position = firBG.position + Vector3.right * length;
        }
        
        if(mainCam.position.x > thiBG.position.x)
        {
            Transform a = firBG;
            firBG = thiBG;
            thiBG = a;
            Transform b = secBG;
            secBG = firBG;
            firBG = b;
        }
    }
}
