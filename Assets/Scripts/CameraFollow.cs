using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform mainTransform;
    [SerializeField] private Transform target;
    private Vector3 velocity = Vector3.zero;

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 currentPosforX = mainTransform.position;
        Vector3 smoothPositionforX = Vector3.SmoothDamp(mainTransform.position, target.position, ref velocity, 0.15f);
        currentPosforX.x = smoothPositionforX.x;
        mainTransform.position = currentPosforX;

        Vector3 currentPosforY = mainTransform.position;
        Vector3 smoothPositionforY = Vector3.SmoothDamp(mainTransform.position, target.position, ref velocity, 0.15f);
        currentPosforY.y = smoothPositionforY.y;
        mainTransform.position = currentPosforY;
    }
}
