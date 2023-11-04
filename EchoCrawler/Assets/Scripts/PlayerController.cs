using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second
    public float tileMoveDistance = 1.0f; // Adjust this value to match your tile size

    private Rigidbody2D rb;
    private GameObject player;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            MoveForward();
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            RotateLeft();
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            RotateRight();
        }
    }

    private void MoveForward()
    {
        Vector2 forwardDirection = transform.up;
        Vector2 newPosition = rb.position + forwardDirection * tileMoveDistance;
        rb.MovePosition(newPosition);
    }

    private void RotateLeft()
    {
        transform.Rotate(0, 0, 90); // Rotate 90 degrees left (A key)
    }

    private void RotateRight()
    {
        transform.Rotate(0, 0, -90); // Rotate 90 degrees right (D key)
    }

}
