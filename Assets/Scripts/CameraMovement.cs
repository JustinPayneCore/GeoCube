using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;

    // Update method for camera, called once per frame.
    void Update()
    {
        // Sets the camera's position to the player position plus a default offset
        transform.position = player.position + offset;
    }
}
