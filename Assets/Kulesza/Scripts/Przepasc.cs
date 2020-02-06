using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Przepasc : MonoBehaviour
{
    public GameObject przycisk;
    private SpriteRenderer button;
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

        button = GetComponent<SpriteRenderer>();
        
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
            button.color = new Color(1f,0.4f,0f,0.7f);
            przycisk.transform.Translate(Vector2.up * 0.5f, Space.World);
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
        button.color = new Color(1f, 0.4f, 0f, 1f);
        przycisk.transform.Translate(Vector2.up * -0.5f, Space.World);
        otwarte = true;
    }
}
