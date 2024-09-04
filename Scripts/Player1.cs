using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player1 : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 position;
    private Vector2 direction;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        position = this.transform.position;
    }

    private void Update()
    {
        // Gets direction for use in the calculation of paddle velocity
        direction = PlayerController.Player1Input(position);
    }

    private void FixedUpdate()
    {
        position = this.transform.position;
        // Passes the direction determined in Update() to the PlayerMovement() method in the PlayerController script
        // Uses the return value to set the velocity of this rigidbody (a component of the player paddle)
        rb.velocity = PlayerController.PlayerMovement(direction);
    }
}