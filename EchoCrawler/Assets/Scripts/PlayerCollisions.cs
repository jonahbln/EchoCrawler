using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public static bool touchingWall = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Door"))
        {
            touchingWall = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall") || collision.gameObject.CompareTag("Door"))
        {
            touchingWall = false;
        }
    }
}
