using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{   
   [SerializeField] private float speed;
   private Rigidbody2D body;

   private Animator animator;

   private bool grounded;

   private void Awake()
   {
        body = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
   }

   private void Update()
   {
        float horizontalInput = Input.GetAxis("Horizontal");
        body.linearVelocity = new Vector2(horizontalInput * speed, body.linearVelocity.y);

        if (horizontalInput > -0.01f)
        {
            transform.localScale = new Vector3(1,1,1);
        }
        else if (horizontalInput < 0.01f)
        {
            transform.localScale = new Vector3(-1,1,1);
        }

        if (Input.GetKey(Keycode.Space) && grounded)
        {
            Jump();
        }

        
        animator.SetBool("run", horizontalInput != 0);
        animator.SetBool("grounded", grounded);

   }

   private void Jump()
   {
      body.linearVelocity = new Vector2(body.linearVelocity.x, speed); // version 6
      animator.SetTrigger("jump");
      grounded = false;
   }

   void OnCollisionEnter2D(Collision2D collision)
   {
      if (collision.gameObject.tag == "Ground")
      {
        grounded = true;
      }
   }
    
}
