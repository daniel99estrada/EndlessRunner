using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public Transform player;    // Reference to the player's transform
    public Vector3 offset;     // The initial offset between the camera and player

    void Start()
    {

    }

    void LateUpdate()
    {
        // Update the camera's position to follow the player while maintaining the original offset
        transform.position = player.position + offset;
    }
}
