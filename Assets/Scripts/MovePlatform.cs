using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlatform : MonoBehaviour
{
    // Sets two points for object to bounce between
    Vector3 pointA = new Vector3(60, 15, 56);
    Vector3 pointB = new Vector3(40, 15, 56);
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Object will bounce between the two points that were set
        transform.position = Vector3.Lerp(pointA, pointB, Mathf.PingPong(Time.time, 1));
    }
}
