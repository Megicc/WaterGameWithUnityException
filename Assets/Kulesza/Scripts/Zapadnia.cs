using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zapadnia : MonoBehaviour
{
    public GameObject[] zapadnia;
    public float time;
    public GameObject interakcja;

    public bool otwarte;
    private void Start()
    {
        zapadnia = GameObject.FindGameObjectsWithTag("Zapadnia");
    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        interakcja.SetActive(true);

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

    private void OnTriggerExit2D(Collider2D collision)
    {
        interakcja.SetActive(false);

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
