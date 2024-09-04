using UnityEngine;

public static class PlayerController
{
    private static int speed = 30;
    private static float wallPosition = 13.0f;

    private static Vector2 direction;
    private static Vector2 velocity;

    // Called by Player1's Update() method
    // Gets direction of Player1 paddle based on user input
    public static Vector2 Player1Input(Vector3 pos)
    {
        if (Input.GetKey(KeyCode.W) && pos.y < wallPosition)
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.S) && pos.y > -wallPosition)
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
        return direction;
    }

    // Called by Player2's Update() method
    // Gets direction of Player2 paddle based on user input
    public static Vector2 Player2Input(Vector3 pos)
    {
        if (Input.GetKey(KeyCode.UpArrow) && pos.y < wallPosition)
        {
            direction = Vector2.up;
        }
        else if (Input.GetKey(KeyCode.DownArrow) && pos.y > -wallPosition)
        {
            direction = Vector2.down;
        }
        else
        {
            direction = Vector2.zero;
        }
        return direction;
    }

    // Called by Player1 and Player2 in their FixedUpdate() methods
    // Passed the direction argument from the Players' Update() methods, which is used to calculate and return the velocity of the given paddle
    public static Vector2 PlayerMovement(Vector2 dir)
    {
        if (dir != Vector2.zero)
        {
            velocity = dir * speed;
        }
        else
        {
            velocity = Vector2.zero;
        }
        return velocity;
    }
}
