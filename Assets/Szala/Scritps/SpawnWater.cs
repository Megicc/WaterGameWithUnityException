using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnWater : MonoBehaviour
{
    public GameObject water;
    public float ilosc;
    private float i = 0;
    public Vector3 spawnCoordinates;
    //public GameObject Spawner;


    private void Awake()
    {
        //spawnCoordinates = Spawner.transform.position;
    }
    private void Start()
    {
        while(i < ilosc)
        {
            Instantiate(water, spawnCoordinates, Quaternion.identity);
            i++;
        }

    }

}
