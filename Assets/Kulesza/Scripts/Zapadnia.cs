using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zapadnia : MonoBehaviour
{
    public GameObject[] zapadnia;
    public float time;

    public bool otwarte;
    private void Start()
    {
        zapadnia = GameObject.FindGameObjectsWithTag("Zapadnia");
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && otwarte == true)
        {

            foreach(GameObject wlaz in zapadnia)
            {
                wlaz.SetActive(false);
                otwarte = false;
                StartCoroutine("Przymknij");
            }            
        }
    }

    IEnumerator Przymknij()
    {
        yield return new WaitForSeconds(time);
        foreach (GameObject wlaz in zapadnia)
        {
            wlaz.SetActive(true);
            otwarte = true;
        }
    }
}
