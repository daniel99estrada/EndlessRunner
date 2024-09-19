using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed = 10f;           // Movement speed
    public float sideSpeed = 15f;        // Speed for moving sideways
    private Rigidbody rb;                // Rigidbody component

    void Start()
    {
        // Get the Rigidbody component attached to the player
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        // Move the player forward constantly
        MoveForward();

        // Handle input for left and right movement
        HandleInput();

        if(rb.position.y < -3f){
            GameManager.Instance.EndGame();
        }
    }

    void MoveForward()
    {
        // Apply force to move forward constantly
        rb.AddForce(transform.forward * speed * Time.deltaTime, ForceMode.VelocityChange);
    }

    void HandleInput()
    {
        // Move left (A key)
        if (Input.GetKey(KeyCode.A))
        {
            rb.AddForce(-transform.right * sideSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }

        // Move right (D key)
        if (Input.GetKey(KeyCode.D))
        {
            rb.AddForce(transform.right * sideSpeed * Time.deltaTime, ForceMode.VelocityChange);
        }
    }
}
