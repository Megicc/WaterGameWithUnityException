using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWater : MonoBehaviour
{
    public Transform water;

    public bool czyZniszczony = false;

    public void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Spike" || col.tag == "Down")
        {


            czyZniszczony = true;
        }
    }


}
