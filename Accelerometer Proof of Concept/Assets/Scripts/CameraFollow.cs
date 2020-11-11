﻿
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Reference to followed obj
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;
    
    void FixedUpdate() {
        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothPosition;
    }
}


