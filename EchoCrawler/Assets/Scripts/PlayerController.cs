using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 1.0f; // Adjust this to control movement speed
    private bool canMove = true;

    private void Update()
    {
        if (canMove)
        {
            float horizontalInput = Input.GetAxis("Horizontal");
            float verticalInput = Input.GetAxis("Vertical");

            Vector3 moveDirection = new Vector3(horizontalInput, verticalInput, 0);

            if (moveDirection != Vector3.zero)
            {
                // Calculate the target position
                Vector3 targetPosition = transform.position + moveDirection;

                // Move the player to the target position with snapping to the grid
                transform.position = new Vector3(Mathf.Round(targetPosition.x), Mathf.Round(targetPosition.y), 0);
            }
        }
    }
}
