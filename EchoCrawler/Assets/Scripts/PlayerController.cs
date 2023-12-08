using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class PlayerController : MonoBehaviour
{
    public float rotationSpeed = 90f; // Rotation speed in degrees per second
    public float tileMoveDistance = 1.0f; // Adjust this value to match your tile size

    private Rigidbody2D rb;
    private GameObject player;

    public static bool canMove = true;

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

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

                DisableInput();
                if (!PlayerCollisions.touchingWall)
                {
                    rb.MovePosition(transform.position + transform.up);
                    GetComponent<SoundController>().PlayMoveFoward();
                }
                else
                {
                    GetComponent<SoundController>().PlayWallInteraction();
                }
                Invoke("EnableInput", .4f);

            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
            {
                DisableInput();
                GetComponent<SoundController>().PlayRotateLeft();
                transform.Rotate(0, 0, 90);
                Invoke("EnableInput", .4f);

            }
            else if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
            {
                DisableInput();
                GetComponent<SoundController>().PlayRotateRight();
                transform.Rotate(0, 0, -90);
                Invoke("EnableInput", .4f);

            }
        }

        }
    

    private void DisableInput()
    {
        canMove = false;
        EchoHandler.canEcho = false;
    }

    private void EnableInput()
    {
        canMove = true;
        EchoHandler.canEcho = true;
    }
}
