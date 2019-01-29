using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroController : MonoBehaviour {
    public bool facingRight = true; 
    private Rigidbody2D theRigidBody;
    public float horizontalSpeed; 
    private float move;
    public Transform groundCheck;
    public LayerMask whatIsGround;
    public float groundRadius;
    public bool grounded;

    // Use this for initialization
    void Start () {
        theRigidBody = GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        move = Input.GetAxisRaw("Horizontal");
        theRigidBody.velocity = new Vector2(horizontalSpeed * move, theRigidBody.velocity.y);
        Collider2D colliderWeCollidedWith = Physics2D.OverlapCircle(groundCheck.position, groundRadius, whatIsGround);
        grounded = (bool)colliderWeCollidedWith;
    }
    void Move()
    {
        if (move > 0 && !facingRight) //if move is greater than 0 and not facing right, flip the sprite
        {
            Flip();
        }
        else if (move < 0 && facingRight)
        {
            Flip();
        }
        if (grounded) //if grounded is true...
        {
            theRigidBody.velocity = new Vector2(0, theRigidBody.velocity.y);//the rigid body's x and y coordinates must be 0 and the value of the y velocity of the rigid body respectively
        }
    }

    void Flip()
    {
        // Toggle the value of facingRight i.e. put it equal to what
        // it is not currently
        facingRight = !facingRight;

        theRigidBody.transform.Rotate(0f, 180f, 0f); //flip the hero to face the left
    }
}
