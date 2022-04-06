using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Create the variables for player physics
    private CharacterController controller;
    private Vector3 playerVelocity;
    private bool groundedPlayer;
    private float playerSpeed = 4.0f;
    private float jumpHeight = 2.0f;
    private float gravity = -9.81f;

    // Add character controller on start
    private void Start()
    {
        controller = gameObject.AddComponent<CharacterController>();
    }

    // Called each frame and updates player
    void Update()
    {
        // Make sure player is on the ground
        groundedPlayer = controller.isGrounded;

        // Sets velocity to 0 if grounded and velocity is less than zero
        if (groundedPlayer && playerVelocity.y < 0)
        {
            playerVelocity.y = 0f;
        }

        // Gets input on vertical and horizontal movement and put into a variable
        Vector3 move = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        // Move according to the playerspeed variable
        controller.Move(move * Time.deltaTime * playerSpeed);

        // 
        if (move != Vector3.zero)
        {
            gameObject.transform.forward = move;
        }

        // Changes the height position of the player
        if (Input.GetButtonDown("Jump") && groundedPlayer)
        {
            playerVelocity.y += Mathf.Sqrt(jumpHeight * -3.0f * gravity);
        }

        // Accounts for gravity in player movement
        playerVelocity.y += gravity * Time.deltaTime;
        controller.Move(playerVelocity * Time.deltaTime);
    }
}