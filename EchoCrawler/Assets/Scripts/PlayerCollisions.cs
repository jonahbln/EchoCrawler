using UnityEngine;

public class PlayerCollisions : MonoBehaviour
{
    public int Bonk = 0;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.gameObject.CompareTag("Wall"))
        {
            // If the collided object is tagged as "Wall," prevent the player from moving
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            GetComponent<PlayerController>().MoveBackwards();
            GetComponent<SoundController>().PlayWallInteraction();
            Bonk++;
            print(Bonk);
        }
    }
}
