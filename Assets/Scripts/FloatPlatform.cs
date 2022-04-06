using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloatPlatform : MonoBehaviour
{
    // Set variables for the positons of the platform
    private float originalYPosition;
    private float originalXPosition;
    private bool movedUp = false;
    private bool movedDown = false;
    private float moveBy = .1f;
 
    // Use this for initialization
    void Start () {

        // Start at our original positions
        originalYPosition = transform.position.y;
        originalXPosition = transform.position.x;
 
    }
 
    // Update is called once per frame
    void Update () {
        
        // Moves object between two points
        if(!movedUp)
        {
            Vector2 position = Vector2.Lerp((Vector2)(transform.position), new Vector2(originalXPosition, 2.6f), Time.fixedDeltaTime);
            transform.position = position;
        }
        else if(!movedDown)
        {
            Vector2 position = Vector2.Lerp((Vector2)(transform.position), new Vector2(originalXPosition, 2.0f), Time.fixedDeltaTime);
            transform.position = position;
        }

        // Sets moving variables based on position
        if(transform.position.y >= 2.59f)
        {
            movedUp = true;
            movedDown = false;
        }
        else if(transform.position.y <= 2.01f)
        {
            movedDown = true;
            movedUp = false;
        }
 
    }
}
