using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    [SerializeField] private Transform mainTransform;
    [SerializeField] private float time;
    [SerializeField] private float durationTime;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(FireRoutine());
        IEnumerator FireRoutine()
        {
            time = 0;
            while (time <= durationTime )
            {
                mainTransform.position += mainTransform.up * moveSpeed * Time.deltaTime;
                time = time + Time.deltaTime;
                yield return null;
            }
            Destroy(gameObject);
        }
    }


}