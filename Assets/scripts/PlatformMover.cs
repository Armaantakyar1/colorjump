using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Transform startPoint;
    public Transform endPoint;
    public float duration;

    private float currentTime = 0f;

    private void Update()
    {
        float t = Mathf.PingPong(Time.time / duration, 1f);
        transform.position = Vector3.Lerp(startPoint.position, endPoint.position, t);
    }
}


