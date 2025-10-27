// using UnityEngine;

// public class BasicMove : MonoBehaviour
// {
//     [Header("Movement Settings")]
//     public float moveSpeed = 5f;

//     private Rigidbody rb;
//     private Vector3 moveInput;

//    void Start()
// {
//     rb = GetComponent<Rigidbody>();
// }


//     void Update()
//     {
//         // Get movement input (WASD or Arrow keys)
//         float moveX = Input.GetAxisRaw("Horizontal"); // A/D → Left/Right
//         float moveZ = Input.GetAxisRaw("Vertical");   // W/S → Forward/Backward

//         // Combine inputs into a direction vector
//         moveInput = new Vector3(moveX, 0f, moveZ).normalized;
//     }

//     void FixedUpdate()
//     {
//         if (rb != null)
//         {
//             // Move the player based on physics
//             rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
//         }
//     }
// }

using UnityEngine;

public class BasicMove : MonoBehaviour
{
    [Header("Movement Settings")]
    public float moveSpeed = 5f;

    private Rigidbody rb;
    private Vector3 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Get movement input (WASD or Arrow keys)
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D → Left/Right
        float moveZ = Input.GetAxisRaw("Vertical");   // W/S → Forward/Backward

        // Combine inputs into a direction vector
        moveInput = new Vector3(moveX, 0f, moveZ).normalized;
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            // Move the player based on physics
            rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        }
    }
}