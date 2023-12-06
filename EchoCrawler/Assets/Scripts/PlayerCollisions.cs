using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public static bool touchingWall = false;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            touchingWall = true;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Wall"))
        {
            touchingWall = false;
        }
    }
}
