using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidbody;
    [SerializeField] private SpriteRenderer mainSpriteRenderer;
    [SerializeField] private float moveSpeed;


    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
            mainRigidbody.AddForce(new Vector2(-moveSpeed * Time.deltaTime, 0));
            mainSpriteRenderer.flipX = true;
        }

        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            mainRigidbody.AddForce(new Vector2(moveSpeed * Time.deltaTime, 0));
            mainSpriteRenderer.flipX = false;
        }

        if (Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.UpArrow))
        {
            mainRigidbody.AddForce(new Vector2(0, 10));
        }
    }
}
