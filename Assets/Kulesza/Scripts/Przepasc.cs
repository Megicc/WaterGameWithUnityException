using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przepasc : MonoBehaviour
{
    public GameObject przepasc;


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            
            przepasc.SetActive(true);
        }
    }

}
