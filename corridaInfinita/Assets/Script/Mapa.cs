using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{
    GameObject clone;
    public GameObject chao;
    float position, time, time2;
    public float maxtime;
    void Start()
    {
        Clone();
        position = -4f;
    }

    
    void Update()
    {
        time += Time.deltaTime;
        if (time >= maxtime)
        {
            position += 9f;
            time = 0;
            Clone();
        }
        
    }
    void Clone()
    {
        clone = Instantiate(chao);
        clone.transform.position = new Vector3(position, -3, 0);
    }

}
