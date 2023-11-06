using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Wall"))
        {
            // If the collided object is tagged as "Wall," prevent the player from moving
            GetComponent<Rigidbody2D>().velocity = Vector2.zero;
            GetComponent<SoundController>().PlayWallInteraction();
        }
    }
}
