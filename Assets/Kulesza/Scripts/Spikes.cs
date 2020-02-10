using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject[] spike;

    public float time;
    public bool schowane;


    private void Start()
    {
        spike = GameObject.FindGameObjectsWithTag("Spike");

    }


    private void OnTriggerStay2D(Collider2D collision)
    {
        if (Input.GetKeyDown(KeyCode.F) && schowane == true)
        {           
            //spike.SetActive(false);
            foreach(GameObject kolce in spike)
            {
                kolce.SetActive(false);
            }
            schowane = false;
            StartCoroutine("Schowaj");
        }
    }

    IEnumerator Schowaj()
    {
        yield return new WaitForSeconds(time);
        foreach(GameObject kolce in spike)
        {
            kolce.SetActive(true);
        }
        //spike.SetActive(true);
        schowane = true;
    }

}
