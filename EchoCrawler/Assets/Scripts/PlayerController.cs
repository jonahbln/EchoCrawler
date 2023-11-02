using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second
    public float tileMoveDistance = 1.0f; // Adjust this value to match your tile size

    private Rigidbody2D rb;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool canMove = true; // Initialize as true to allow initial movement

    private bool moveForward = false;
    private bool moveLeft = false;
    private bool moveRight = false;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Get button inputs from the player
        moveForward = Input.GetKeyDown(KeyCode.W);
        moveLeft = Input.GetKeyDown(KeyCode.A);
        moveRight = Input.GetKeyDown(KeyCode.D);
    }

    private void FixedUpdate()
    {
        // Rotate the player based on input
        if (moveLeft && !isRotatingLeft && canMove)
        {
            isRotatingLeft = true;
            isRotatingRight = false;
            transform.Rotate(0, 0, 90); // Rotate 90 degrees left (A key)
            canMove = false; // Set canMove to false after key press
        }
        else if (moveRight && !isRotatingRight && canMove)
        {
            isRotatingRight = true;
            isRotatingLeft = false;
            transform.Rotate(0, 0, -90); // Rotate 90 degrees right (D key)
            canMove = false; // Set canMove to false after key press
        }

        if (!moveLeft && !moveRight)
        {
            isRotatingLeft = false;
            isRotatingRight = false;
            canMove = true; // Reset canMove when not pressing A or D
        }

        // Move the player forward by a fixed tile distance when pressing W
        if (moveForward && canMove)
        {
            Vector2 forwardDirection = transform.up;
            Vector2 newPosition = rb.position + forwardDirection * tileMoveDistance;
            rb.MovePosition(newPosition);
            canMove = false; // Set canMove to false after key press
        }
    }
}
