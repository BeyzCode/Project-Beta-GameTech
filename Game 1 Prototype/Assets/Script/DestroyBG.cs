using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyBG : MonoBehaviour
{
    float lifetime = 5f;
    float timer;
 
    void Update()
    {
        timer += Time.deltaTime;
    
        if(timer >= lifetime)
        Destroy(gameObject);
    }
}
