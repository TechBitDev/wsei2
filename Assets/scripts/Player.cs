using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private short inputMultiplier = 1;

    public GameObject mirror;



    public bool hasKey = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * playerSpeed * inputMultiplier, rb.linearVelocity.y);

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.linearVelocity = new Vector2(rb.linearVelocity.x, jumpForce);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("touched enemy");
            SendMessage("playDeathAnimationSkull");
            Destroy(GameObject.Find("Player"));
            Debug.Log("aa");
        }

    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("MirrorGlass"))
        {
            Debug.Log("inverting horizontal controls");
            inputMultiplier *= -1;
        }
    }
}