using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement playerMovement;

    private void OnCollisionEnter(Collision collision)
    {
        // If the player collides with an object tagged as obstacle, disables player movement.
        if (collision.collider.CompareTag("Obstacle"))
        {
            playerMovement.enabled = false;

        }
    }
}
