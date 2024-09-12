using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mapa : MonoBehaviour
{
    GameObject clone,clonedois;
    public GameObject chao, cacto,trajeto, trajeto2;
    float position, time;
    public float maxtime, time2;
    public int tempoAleatorio;
    void Start()
    {
        Timer_aleatory();
       
        Clone();
        position = -4f;
    }

    
    void Update()
    {
        time += Time.deltaTime;
        if (time >= maxtime)
        {
            position += 530f;
            time = 0;
            Clone();
        }
        
        time2 += Time.deltaTime;
        if (time2 >= tempoAleatorio)
        {
            time2 = 0;
            Timer_aleatory();
        }
       



    }
    void Clone()
    {
        clone = Instantiate(chao);
        clone.transform.position = new Vector3(position, -3, 0);
    }
    
    void clone2()
    {
        clonedois = Instantiate(cacto);
        clonedois.transform.position = trajeto.transform.position;//Vector3.MoveTowards(clonedois.transform.position, trajeto.transform.position, 400);
    }
    void Timer_aleatory()
    {
        clone2();
        tempoAleatorio = Random.Range(5, 10);
       
    }


}
