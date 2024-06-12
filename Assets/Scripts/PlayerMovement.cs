using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce = 100;
    public float sidewaysForce = 100;

    // Update method tracking player inputs for movement and adding correct force.
    void FixedUpdate()
    {
        if (!FindObjectOfType<GameManager>().gameHasEnded)
        {
            // Adds a default forward force
            rb.AddForce(0, 0, forwardForce * Time.deltaTime);

            // If the d key is pressed, add a right velocity to the player.
            if (Input.GetKey("d"))
            {
                rb.AddForce(sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            // If the a key is pressed, add a left velocity to the player.
            if (Input.GetKey("a"))
            {
                rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            }

            // If the player falls off the stage, cause the player to lose.
            if (rb.position.y < -1)
            {
                FindObjectOfType<GameManager>().FailLevel();

            }
        }

    }
}
