using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Sign : MonoBehaviour
{
    public KeyCode interactkey;
    public UnityEvent interactaction;
    public Animator animator;
    public bool isAnimating;

    private void Update()
    {
        // Check for user input to interact
        if (Input.GetKeyDown(interactkey) && (!isAnimating))
        {
            // Start the animation if not already playing
            animator.SetTrigger("StartAnimation");
            isAnimating = true;

            // start the interaction event
            interactaction.Invoke();
        }
    }

    // This method should be called from an animation event at the end of your animation
    public void AnimationComplete()
    {
        isAnimating = false;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player")) // entering the body area
        {
            animator.SetBool("Animate", true);
            
            // ("Press E to interact")
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            animator.SetBool("Animate", false);

            // (remove press E to interact)
        }
    }
}
