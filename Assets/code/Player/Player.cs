using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed ;
    public float jumpSpeed ;
    public float jumpLimit;
    float jumpCount, gx, sx;
    Rigidbody2D rb;
    Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        sx = transform.localScale.x;
        animator = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Jump") && jumpCount < jumpLimit)
        {
            jumpCount++;
            rb.velocity = new Vector2(rb.velocity.x, jumpSpeed );
        }
        gx = Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(gx));
        rb.velocity = new Vector2(gx * speed,rb.velocity.y);
        if(gx > 0)
        {
            transform.localScale = new Vector3(sx, transform.localScale.y, transform.localScale.z);
        }
        if (gx < 0)
        {
            transform.localScale = new Vector3(-sx, transform.localScale.y, transform.localScale.z);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        jumpCount = 0;
    }
}
