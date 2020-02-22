using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MultipleTargetsCamera : MonoBehaviour
{
    public List<Transform> targets;
    public Vector3 offset;
    private Vector3 velocity;
    public float smoothTime = 0.5f;
    public float destroy = 20f;
    public int gravChange = -1;
    //public Camera mainCamera;


    private void Start()
    {
        //cam.GetComponent<Camera>();
        
    }

    private void Update()
    {
        Transform waterParticle;
        int waterIndex = 0;
        bool toDelete = false;
        //destroy = gameObject.GetComponent<Transform>().position.y;

        for (int i = 0; i < targets.Count; i++)
        {
            waterParticle = targets[i];

            if (waterParticle.GetComponent<Transform>().position.y < -destroy)
            {
                waterIndex = i;
                toDelete = true;
                break;
            }

        }

        if (toDelete)
        {
            targets.RemoveAt(waterIndex);
            toDelete = false;
        }


        if (Input.GetKey(KeyCode.G))
        {
            if (gravChange < 0)
            {
                setGravity();
            }
            else;
            {
                gravChange = -gravChange;
                setGravity();
            }

        } else if (Input.GetKey(KeyCode.H))
        {
            if (gravChange < 0)
            {
                gravChange = -gravChange;
                setGravity();
            }
            else
            {
                setGravity();
            }
        }

    }

    private void LateUpdate()
    {
        if(targets.Count == 0)
        {

            return;
           
        }
        Vector3 centerPoint = GetCenterPoint();

        Vector3 newPosition = centerPoint + offset;

        transform.position = Vector3.SmoothDamp(transform.position, newPosition, ref velocity, smoothTime);


    }


    Vector3 GetCenterPoint()
    {
        if(targets.Count == 1)
        {
            return targets[0].position;

        }

        var bounds = new Bounds(targets[0].position, Vector3.zero);
        for (int i = 0; i < targets.Count ; i++)
        {
            bounds.Encapsulate(targets[i].position);
        }
        return bounds.center;
    }

    private void setGravity()
    {

        for (int i = 0; i < targets.Count; i++)
        {
            targets[i].GetComponent<Rigidbody2D>().gravityScale = gravChange;

        }
    }
}
