using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 5.0f;

    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, 0.0f, verticalInput);
        movement.Normalize();

        if (movement.magnitude > 0.1)
        {
            rb.velocity = movement * moveSpeed;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shout();
        }
    }

    void Shout()
    {
    }
}