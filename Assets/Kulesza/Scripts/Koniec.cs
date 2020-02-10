using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Koniec : MonoBehaviour
{
    public GameObject woda;
    public GameObject koniec;


    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Woda")
        {
            koniec.SetActive(true);
        }
    }


}
