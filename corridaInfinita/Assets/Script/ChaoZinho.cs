using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChaoZinho : MonoBehaviour
{
    float time;
    void Start()
    {
        
    }

    
    void Update()
    {
        time = Time.deltaTime;
        if(time >= 0.8f)
        {
            Destroy(gameObject);
        }
    }
}
