using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Rigidbody2D R;
    public float GoGoGo;
    public float GoGoGo2;
    void Start()
    {
        R = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        ande();
        if (Input.GetKey(KeyCode.Space))
        {
            pule();
        }
    }
    void ande()
    {
        R.velocity = new Vector3(GoGoGo, 0);
    }
    void pule()
    {
        R.velocity = new Vector3(GoGoGo, GoGoGo2);
    }
}
