using UnityEditor.Animations;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed = 5f;
    public float jumpForce = 10f;
    private Rigidbody2D rb;
    private bool isGrounded;
    private short inputMultiplier = 1;
    private Animator anim;
    public GameObject mirror;
    [Header("Animation")]
    [SerializeField] private AnimationClip move_left;
    [SerializeField] private AnimationClip move_right;
    [SerializeField] private AnimationClip stay;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * playerSpeed * inputMultiplier, rb.linearVelocity.y);
        if (Input.GetKeyDown(KeyCode.D)) transform.localScale = new Vector3(-3, 3, 1);
        else if (Input.GetKeyDown(KeyCode.A)) transform.localScale = new Vector3(3, 3, 1);
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

        if (other.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("touched enemy");
            SendMessage("playDeathAnimationSkull");
            Destroy(GameObject.Find("Player"));
            Debug.Log("aa");
        }

    }
}