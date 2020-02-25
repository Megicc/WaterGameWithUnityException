using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zapadnia : MonoBehaviour
{
    public GameObject zapadnia;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            zapadnia.SetActive(false);
        }
    }
}
