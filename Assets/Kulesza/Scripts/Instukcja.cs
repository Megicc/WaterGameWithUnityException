using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Instukcja : MonoBehaviour
{
    public GameObject interakcja;
    public GameObject instrukcja;
    public bool wyswietlone = false;
    

    public void OnTriggerStay2D(Collider2D other)
    {
        interakcja.SetActive(true);
        if (Input.GetKeyDown(KeyCode.F) && wyswietlone == false)
        {
            instrukcja.SetActive(true);
            wyswietlone = true;
           
            
        }
        else if(wyswietlone == true && Input.GetKeyDown(KeyCode.F))
        {
            instrukcja.SetActive(false);
            wyswietlone = false;
            
           
        }
    }

    


    private void OnTriggerExit2D(Collider2D collision)
    {
        interakcja.SetActive(false);

    }

}
