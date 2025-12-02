using UnityEngine;

public class Player : MonoBehaviour
{
    [field: SerializeField] private float moveSpeed = 5f;
    public float MoveSpeed
    {
        get { return moveSpeed; }
        set { if (value <= 0) value = 0; else moveSpeed = value;}
    }

    [field: SerializeField] private float jumpForce = 10f;
    public float JumpForce
    {
        get { return jumpForce; } 
        set { if (value <= 0) value = 0; else jumpForce = value; }
    }
    [field: SerializeField] private bool isInvulnereble;
    public bool IsInvulnereble
    {
        get { return isInvulnereble; }
        set { isInvulnereble = value; }
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
    public void SetMoveSpeed(float newSpeed)
    {
         MoveSpeed = newSpeed;
    }
    public void SetInvulnereble(bool Invulnereble)
    {
        IsInvulnereble = Invulnereble;
    }
    public void SetJumpForce (float NewJumpForce)
    {
        JumpForce = NewJumpForce;
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other != null)
        {
            Debug.Log("Im forgot this to excute code form another class");        }
    }

}
