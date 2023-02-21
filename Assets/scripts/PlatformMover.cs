using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public Vector3 startPosition;
    public Vector3 endPosition;
    public float speed = 1.0f;

    private float journeyLength;
    private float startTime;

    void Start()
    {
        journeyLength = Vector3.Distance(startPosition, endPosition);
        startTime = Time.time;
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        transform.position = Vector3.Lerp(startPosition, endPosition, fracJourney);

        if (transform.position == endPosition)
        {
            startTime = Time.time;
            Vector3 temp = startPosition;
            startPosition = endPosition;
            endPosition = temp;
        }
    }
}

