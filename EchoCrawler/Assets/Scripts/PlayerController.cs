using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second
    public float tileMoveDistance = 1.0f; // Adjust this value to match your tile size

    private Rigidbody2D rb;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        // Get input from the player
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        // Rotate the player based on input
        if (horizontalInput < 0 && !isRotatingLeft)
        {
            isRotatingLeft = true;
            isRotatingRight = false;
            transform.Rotate(0, 0, 90); // Rotate 90 degrees left (A key)
        }
        else if (horizontalInput > 0 && !isRotatingRight)
        {
            isRotatingRight = true;
            isRotatingLeft = false;
            transform.Rotate(0, 0, -90); // Rotate 90 degrees right (D key)
        }

        if (horizontalInput == 0)
        {
            isRotatingLeft = false;
            isRotatingRight = false;
        }

        // Move the player forward by a fixed tile distance when pressing W
        if (verticalInput > 0)
        {
            Vector2 forwardDirection = transform.up;
            Vector2 newPosition = rb.position + forwardDirection * tileMoveDistance;
            rb.MovePosition(newPosition);
        }
    }
}
