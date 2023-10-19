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
    private Transform characterTransform;
    private SpriteRenderer characterSpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        characterTransform = transform;
        characterSpriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
    /*
        assigning "Horizontal" movement key, has already been configured for left and right 
        Vector2(x,y) is the format - (change in position of x, change in pos of y
        this is why rn.velocity.y is the way it is, retaining it's position in the game
        thats why it was going in 45 degree angles when we adjusted this var.
        Jump is inbuilt, we cannot use GetAxis since we want him to 'jump' not 'fly'
        always remember that vector2 is in (x,y), and that we need to create a new vector2
        DO NOT CHANGE DEFAULTS IN GRAVITY SCALE IT MESSES EVERYTHING UP, we need to only
    */
        movement = Input.GetAxis("Horizontal");                         
        
        if (isTouchingWater == false)
        {
            rb.velocity = new Vector2(movement * Speed, rb.velocity.y);
            
            if (movement  < 0)
            {
                // to flip our character when it turns left
                characterSpriteRenderer.flipX = true;
            }
            else if(movement > 0)
            {
                // to reset it back to original
                characterSpriteRenderer.flipX = false;
            }
        }
        else
        {
            rb.velocity = new Vector2((movement * Speed) / 2, rb.velocity.y);
        }


        if ((Input.GetButtonDown("Jump")) && (isJumping == false))          
        {
            rb.AddForce(new Vector2(rb.velocity.x, Jump));              
        }
        // doing this to view my real time current velocity
        Debug.Log("Current Velocity" + rb.velocity);
    }
    /*
        nice set of functions - allows us to decide interactions between objects via their tags
        REMEMBER THAT WE HAVE TO ADD WHATEVER INTERACTIONS WE WANT TO THIS FUNCTION,
        WE CANNOT CREATE A NEW FUNCTION FOR THE SAME!!
    */
    private void OnCollisionEnter2D(Collision2D other_objects)          
    {
        // if our player collides with the floor tagged object                                              
        if (other_objects.gameObject.CompareTag("Floor"))               
        {
            // this makes sure our player doesnt have infinite jumps, I added this to the jump
            isJumping = false;                                          
        }                                                                   }

    // why not just do IF and ELSE in the prev function? cus this is on Exit of collision,
    // we need to do them seperately
    private void OnCollisionExit2D(Collision2D other_objects)           
    {
        if (other_objects.gameObject.CompareTag("Floor"))
        {
            isJumping = true;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)                 
    {
        if (collision.CompareTag("Water"))
        {
            isTouchingWater = true;
            // allowing him to jump infinite times in water
            isJumping = false;
        }   
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Water"))
        {
            isTouchingWater = false;
            isJumping = true;
        }
    }
}