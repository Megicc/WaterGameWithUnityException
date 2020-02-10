using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Kamera : MonoBehaviour
{
    public List<Transform> targets;
    public Vector2 offset;
    private Vector2 velocity;
    public float smoothTime;

    
    

    Transform waterParticle;

    private void Update()
    {
        
       

        for (int i = 0; i < targets.Count; i++)
        {
            waterParticle = targets[i];

            if (waterParticle.GetComponent<DestroyWater>().czyZniszczony ==true)
            {
                
                targets.RemoveAt(i);
                Destroy(waterParticle.gameObject);
                 
            }
         

        }

        if (targets.Count == 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }


    }

    
    



    private void LateUpdate()
    {
        if (targets.Count == 0)
            return;

        Vector2 centerPoint = GetCenterPoint();

        Vector2 newPosition = centerPoint + offset;

        transform.position = Vector2.SmoothDamp(transform.position,newPosition, ref velocity,smoothTime);
    }

    Vector2 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;
        }

        var bounds = new Bounds(targets[0].position, Vector2.zero);
        for(int i =0; i <targets.Count; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return bounds.center;
    }


}
