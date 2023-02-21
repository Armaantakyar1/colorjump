using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformMover : MonoBehaviour
{
    public float startX;
    public float endX;
    public float speed = 1.0f;

    private float journeyLength;
    private float startTime;

    void Start()
    {
        journeyLength = Mathf.Abs(startX - endX);
        startTime = Time.time;
    }

    void Update()
    {
        float distCovered = (Time.time - startTime) * speed;
        float fracJourney = distCovered / journeyLength;
        float newX = Mathf.Lerp(startX, endX, fracJourney);
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);

        if (Mathf.Approximately(newX, endX))
        {
            startTime = Time.time;
            float temp = startX;
            startX = endX;
            endX = temp;
        }
    }
}


