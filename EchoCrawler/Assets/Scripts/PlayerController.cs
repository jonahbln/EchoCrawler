using System.Runtime.CompilerServices;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second
    public float tileMoveDistance = 1.0f; // Adjust this value to match your tile size

    private Rigidbody2D rb;
    private GameObject player;

    public static bool canMove = true;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if(canMove)
        {
            if (Input.GetKeyDown(KeyCode.LeftShift))
            {
                MoveForward();

            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                RotateLeft();

            }
            else if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                RotateRight();
            }
        }
    }

    private void MoveForward()
    {
        GetComponent<SoundController>().PlayMoveFoward();
        canMove = false;
        EchoHandler.canEcho = false;
        Vector2 forwardDirection = transform.up;
        Vector2 newPosition = rb.position + forwardDirection * tileMoveDistance;

        //rb.MovePosition(newPosition);

        rb.velocity = forwardDirection * 2;
        Invoke("stopMoving", 0.5f);
    }

    public void MoveBackwards()
    {
        Vector2 forwardDirection = transform.up;
        Vector2 newPosition = rb.position + forwardDirection * tileMoveDistance;

        //rb.MovePosition(newPosition);

        rb.velocity = -forwardDirection;
        Invoke("stopMoving", 0.5f);
    }

    private void stopMoving()
    {
        rb.velocity = Vector2.zero;
        canMove = true;
        EchoHandler.canEcho = true;
    }


    private void RotateLeft()
    {
        GetComponent<SoundController>().PlayRotateLeft();
        transform.Rotate(0, 0, 90); // Rotate 90 degrees left (A key)
    }

    private void RotateRight()
    {
        GetComponent<SoundController>().PlayRotateRight();
        transform.Rotate(0, 0, -90); // Rotate 90 degrees right (D key)
    }

}
