using UnityEngine;

public class test3 : MonoBehaviour
{
    [SerializeField] private int damage;
    public float jumpForce = 5f;
    private Rigidbody2D rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Jump();
        }
    }

    void Jump()
    {
        rb.velocity = new Vector2(rb.velocity.x, jumpForce);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Weak Point")
        {
            //Destroy(collision.gameObject);
        }
    }

}

