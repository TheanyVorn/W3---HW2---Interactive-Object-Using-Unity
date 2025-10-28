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
        float moveX = Input.GetAxisRaw("Horizontal"); // A/D → Left/Right
        float moveZ = Input.GetAxisRaw("Vertical");   // W/S → Forward/Backward

        moveInput = new Vector3(moveX, 0f, moveZ).normalized;
    }

    void FixedUpdate()
    {
        if (rb != null)
        {
            rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
        }
    }
}