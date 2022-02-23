using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongPaddle : MonoBehaviour
{


    [SerializeField] private KeyCode upKey;
    [SerializeField] private KeyCode downKey;
    [SerializeField] private Transform maintransform;
    [SerializeField] private float moveSpeed;
    [SerializeField] private float minY;
    [SerializeField] private float maxY;

    void Update()
    {
        if (Input.GetKey(upKey) && transform.position.y < maxY)
        {
            maintransform.position += new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }
        else if (Input.GetKey(downKey) && transform.position.y > minY)
        {
            maintransform.position -= new Vector3(0, moveSpeed * Time.deltaTime, 0);
        }
    }
 

}


