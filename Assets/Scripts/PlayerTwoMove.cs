using UnityEngine;

public class PlayerTwoMove : MonoBehaviour
{

    // Variables to horizontal and vertical input
    private float horizontalInput;
    private float verticalInput;

    // Variable to player speed
    private float moveSpeed = 5f;

    // Variable to player physics component (Rigidbody2D)
    private Rigidbody2D playerPhysics;

    void Start()
    {        

        // Component reference
        playerPhysics = GetComponent<Rigidbody2D>();

    }

    void Update()
    {

        // Axis inputs to variables
        horizontalInput = Input.GetAxis("HorizontalP2");
        verticalInput = Input.GetAxis("VerticalP2");

        // Calculate inputs x speed in new vector2 and use it to set linear velocity of player physics 
        playerPhysics.linearVelocity = new Vector2(horizontalInput * moveSpeed, verticalInput * moveSpeed);
        
    }

}
