using UnityEngine;

public class Player : MonoBehaviour
{
    private float moveSpeed = 5f;
    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { if (value <= 0) value = 0; else moveSpeed = value;}
    }

    private float jumpForce = 10f;
    public float JumpForce
    {
        get { return jumpForce; } 
        set { if (value <= 0) value = 0; else jumpForce = value; }
    }

    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");

        rb.linearVelocity = new Vector2(moveInput * MoveSpeed, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {

            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
            
        }
    }
}
