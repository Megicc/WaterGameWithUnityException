using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Vector3 moveRight;
    private Vector3 currentPosition;
    private Vector3 StartPosition = new Vector3(2.4603f, 4.1825f, 2.4603f);
    private void Awake()
    {
        gameObject.transform.localPosition = StartPosition;
        currentPosition = gameObject.transform.localPosition;
        moveRight = new Vector3(0.3f, 0, 0);
    }

    
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.D))
        {
            currentPosition += moveRight;
            gameObject.transform.localPosition = currentPosition;
        }

        if (Input.GetKey(KeyCode.A))
        {
            currentPosition += -moveRight;
            gameObject.transform.localPosition = currentPosition;
        }

    }

}
