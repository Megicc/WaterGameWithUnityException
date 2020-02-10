using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winner : MonoBehaviour
{
    public GameObject winnerSprite;
    GameObject motherfucker;
    
    private void Awake()
    {
        winnerSprite.SetActive(false);
        motherfucker = GameObject.Find("Elevator");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("water"))
        {
            motherfucker.GetComponent<elevator>().enabled = false;
            winnerSprite.SetActive(true);
            //StartCoroutine("loadNext");
        }
    }


    //IEnumerator loadNext()
    //{
    //    yield return new WaitForSeconds(3f);
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}

}
