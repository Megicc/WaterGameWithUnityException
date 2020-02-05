using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przepasc : MonoBehaviour
{ 
    public bool otwarte;

    public float time;

    public GameObject[] przepasc;
    private void Start()
    {
        przepasc = GameObject.FindGameObjectsWithTag("Przepasc");
        foreach (GameObject dziury in przepasc)
        {
            dziury.SetActive(false);

        }
    }

    void OnTriggerStay2D(Collider2D collision)
    {
      if (Input.GetKeyDown(KeyCode.F) && otwarte == true)
      {
        foreach(GameObject dziury in przepasc)
            {
                dziury.SetActive(true);
            }
                 
            otwarte = false;
            StartCoroutine("Otworz");
      }

    }



    IEnumerator Otworz()
    { 
        yield return new WaitForSeconds(time);
       
        foreach (GameObject dziury in przepasc)
        {
            dziury.SetActive(false);
        }
        otwarte = true;
    }
}
