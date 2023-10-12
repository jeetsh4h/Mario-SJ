using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Tilemaps;

public class Movement : MonoBehaviour
{
    public float Speed;                                                 // assigning vars
    public float Jump;                                                  // public so that we can access the vars in unity directly
    public bool isJumping;
    public bool isTouchingWater;

    private float movement;                                             // this assigns left and right movement
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal");                         // assigning Horizontal movement key, has already been configured for left and right
        rb.velocity = new Vector2(movement * Speed, rb.velocity.y);     // Vector2(x,y) is the format - (change in position of x, change in pos of y
                                                                        // this is why rn.velocity.y is the way it is, retaining it's position in the game
                                                                        // thats why it was going in 45 degree angles when we adjusted this var.

        if ((Input.GetButtonDown("Jump")) && (isJumping == false))      // Jump is inbuilt, we cannot use GetAxis since we want him to 'jump' not 'fly'    
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump));              // always remember that vector2 is in (x,y), and that we need to create a new vector2
        }                                                               // DO NOT CHANGE DEFAULTS IN GRAVITY SCALE IT MESSES EVERYTHING UP, we need to only
                                                                        // adjust the jump key scale

        // Debug.Log("Current Velocity" + rb.velocity);                    // doing this to view my real time current velocity
    }

    private void OnCollisionEnter2D(Collision2D other_objects)          // nice function - allows us to decide interactions between objects via their tags
    {                                                                   // REMEMBER THAT WE HAVE TO ADD WHATEVER INTERACTIONS WE WANT TO THIS FUNCTION,
                                                                        // WE CANNOT CREATE A NEW FUNCTION FOR THE SAME!!
        if (other_objects.gameObject.CompareTag("Floor"))                // if our player collides with the floor tagged object
        {
            isJumping = false;                                          // this makes sure our player doesnt have infinite jumps, I added this to the jump
        }                                                               // function above as a parameter
    }

    private void OnCollisionExit2D(Collision2D other_objects)           // why not just do IF and ELSE in the prev function? cus this is on Exit of collision
    {
        if (other_objects.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)                 // TODO: make him die when he touches water
    {
        if (collision.CompareTag("Water"))
        {
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            
        }
    }
}