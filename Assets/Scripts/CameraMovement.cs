using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;

    public Vector3 offset;

    // Update method for camera, called once per frame.
    void Update()
    {
        transform.position = player.position + offset;
    }
}
