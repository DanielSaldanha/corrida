using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destrua : MonoBehaviour
{
    float time;
    public float maxtime;
    void Start()
    {
        
    }

  
    void Update()
    {
        time += Time.deltaTime;
        if(time >= maxtime)
        {
            Destroy(gameObject);
        }
    }
}
