using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    [SerializeField] private Rigidbody2D mainRigidbody;
    [SerializeField] private float startSpeed;
    [SerializeField] private Transform startPosition;

    private static readonly WaitForSeconds wait = new WaitForSeconds(1);
    public void Restart()
    {

        mainRigidbody.position = startPosition.position;
        mainRigidbody.velocity = Vector2.zero;

        StartCoroutine(WaitThenStart());

        IEnumerator WaitThenStart()
        {
            yield return wait; 
            Vector2 newVelocity = new Vector2(Random.Range(-5f, 5f), Random.Range(-1f, 1f));
            mainRigidbody.velocity = newVelocity.normalized * startSpeed;
        }

    }



}
