using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    // Make offset to adjust the camera
    public GameObject player;
    private Vector3 offset = new Vector3(0, 1, -1);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        // Camera will travel with the player using transform
        transform.position = player.transform.position + offset;
    }
}