using UnityEngine;

public class Playermovement : MonoBehaviour
{
    private float playerinput = 0;
    public float speed = 10;
    private Rigidbody2D rb;
    public float jumpspeed = 12;
  

    public Transform groundCheck;
    public float groundRadius = 0.2f;
    public LayerMask groundLayer;
    private bool isGrounded;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        playerinput = Input.GetAxisRaw("Horizontal");
        if(Input.GetKeyDown(KeyCode.Space)&& isGrounded)
        {
            rb.linearVelocityY = jumpspeed;
        }
    }

    private void FixedUpdate()
    {
        rb.linearVelocityX =playerinput*speed;

        isGrounded = Physics2D.OverlapCircle(groundCheck.position,groundRadius,groundLayer);
    }

}
