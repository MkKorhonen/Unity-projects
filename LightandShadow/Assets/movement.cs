using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    Rigidbody2D rb;
    public KeyCode up, right, left;
    public float PlayerSpeed;
    public Vector2 jumpHeight;
    BoxCollider2D bc;
    public LayerMask platformlayermask;
    SpriteRenderer sr;

    // Start is called before the first frame update
    void Start()
    {
        rb = transform.GetComponent<Rigidbody2D>();
        bc = transform.GetComponent<BoxCollider2D>();
        sr = transform.GetComponent<SpriteRenderer>();
        sr.color = new Color(255, 255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if(IsGrounded() && Input.GetKeyDown(up))
		  {
			  rb.velocity = Vector2.up * jumpHeight;
		  }

        if(IsGrounded())
        {
            if(Input.GetKey(left))
            {
            rb.velocity = new Vector2(-PlayerSpeed, rb.velocity.y);
            }

            else if(Input.GetKey(right))
            {
                rb.velocity = new Vector2(+PlayerSpeed, rb.velocity.y);
            }

            else
            {
                rb.velocity = new Vector2(0, rb.velocity.y);
            }
        }

        if(Input.GetKeyDown(KeyCode.Space) && sr.color == new Color(255, 255, 255, 255))
        {
            sr.color = new Color(0, 0, 0, 255);
        }
        
        else if(Input.GetKeyDown(KeyCode.Space) && sr.color == new Color(0, 0, 0, 255))
        {
            sr.color = new Color(255, 255, 255, 255);
        }
    }

    bool IsGrounded()
    {
        RaycastHit2D rch = Physics2D.BoxCast(bc.bounds.center, bc.bounds.size, 1f, Vector2.down, .1f, platformlayermask);
        return rch.collider != null;
    }

    void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals ("movingP"))
        {
            this.transform.parent = col.transform;
        }
        
    }

    void OnCollisionExit2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals ("movingP"))
        {
            this.transform.parent = null;
        }
        
    }

    /*void HandleMovement()
    {
        if(Input.GetKey(left))
        {
            rb.velocity = new Vector2(-PlayerSpeed, rb.velocity.y);
        }

        if(Input.GetKey(right))
        {
            rb.velocity = new Vector2(+PlayerSpeed, rb.velocity.y);
        }

        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }

    }*/
}
