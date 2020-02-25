using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    public Animator animator;
    public Animator animatorSluza1;
    public Animator animatorSluza2;
    public Animator animatorSluza3;
    public GameObject water;
    public GameObject StartSprite;

    private void Awake()
    {
        water.SetActive(false);
        
    }


    private void Start()
    {
        StartSprite.SetActive(true);
    }
    private void Update()
    {
        runWater();
        BridgeOpen();
        Sluza1Open();
        Sluza2Open();
        Sluza3Open();
        //Win();
        
    }

    void BridgeOpen()
    {
        if (Input.GetKey(KeyCode.T))
        {
            animator.SetBool("isQHeld", true);
        }
        if (Input.GetKeyUp(KeyCode.T))
        {
            animator.SetBool("isQHeld", false);
        }
    }

    void runWater()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            water.SetActive(true);
            StartSprite.SetActive(false);
        }
    }

    void Sluza1Open()
    {
        if (Input.GetKey(KeyCode.Q))
        {
            animatorSluza1.SetBool("isQHeld", true);
        }
        if (Input.GetKeyUp(KeyCode.Q))
        {
            animatorSluza1.SetBool("isQHeld", false);
        }
    }

    void Sluza2Open()
    {
        if (Input.GetKey(KeyCode.W))
        {
            animatorSluza2.SetBool("isWHeld", true);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animatorSluza2.SetBool("isWHeld", false);
        }
    }

    void Sluza3Open()
    {
        if (Input.GetKey(KeyCode.E))
        {
            animatorSluza3.SetBool("isEHeld", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animatorSluza3.SetBool("isEHeld", false);
        }
    }
}
