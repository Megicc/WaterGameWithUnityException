using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyWater : MonoBehaviour
{

    public GameObject water;

    private void OnTriggerEnter2D(Collider2D col)
    {
        if(col.tag == "Spike" || col.tag == "Down")
        {
            Destroy(water);
        }
    }


}
