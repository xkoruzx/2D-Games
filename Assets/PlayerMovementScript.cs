using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{   
   [SerializeField] private float speed;
   private Rigidbody2D body;

   private void Awake()
   {
        body = GetComponent<Rigidbody2D>();
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
   }
    
}
