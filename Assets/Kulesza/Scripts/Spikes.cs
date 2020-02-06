using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spikes : MonoBehaviour
{
    public GameObject przycisk;
    public GameObject[] spike;

    public float time;
    public bool schowane;

    private SpriteRenderer button;

    private void Start()
    {
        spike = GameObject.FindGameObjectsWithTag("Spike");
        button = GetComponent<SpriteRenderer>();
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
            button.color = new Color(0f,0.1f,1f,0.7f);
            przycisk.transform.Translate(Vector2.up * 0.5f, Space.World);
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
        button.color = new Color(0f, 0.1f, 1f, 1f);
        przycisk.transform.Translate(Vector2.up * -0.5f, Space.World);
        schowane = true;
    }

}
