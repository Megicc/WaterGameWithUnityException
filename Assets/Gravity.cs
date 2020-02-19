using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gravity : MonoBehaviour
{

    public float gravChange = -1;
    Rigidbody2D rigid;
    

    void Start()
    {

        rigid = GetComponentInChildren<Rigidbody2D>();
       

    }

   
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            rigid.gravityScale = gravChange;
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            rigid.gravityScale = -gravChange;
        }

        
    }
}
