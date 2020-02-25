using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    Vector3 up = new Vector3(0, 0.15f, 0);
    Vector3 down = new Vector3(0, 0.05f, 0);
    public float treshhold;
    
    private void Update()
    {

       
        if (Input.GetKey(KeyCode.K))
        {
            gameObject.transform.position += up;
        }

        if(gameObject.transform.position.y > treshhold)
        {
            gameObject.transform.position += -down;

        }
    }
}
