using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blockade : MonoBehaviour
{
    public GameObject holdK;
    public GameObject blockade;
    



    private void Awake()
    {
        blockade.SetActive(false);
        holdK.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("water"))
        {
            blockade.SetActive(true);
            holdK.SetActive(true);


        }
    }
}
