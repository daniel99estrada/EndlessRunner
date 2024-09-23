using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter(Collision collisionInfo) 
    {
        if (collisionInfo.collider.CompareTag("Obstacle")) 
        {
            movement.enabled = false;
            Debug.Log("You lost");
            GameManager.Instance.EndGame();
        }
    }

    void OnTriggerEnter(Collider other) // Change parameter type to Collider
    {
        if (other.CompareTag("Trigger")) // Use other instead of collisionInfo
        {
            Debug.Log("You Won");
            GameManager.Instance.WinGame();
        }
    }
}
