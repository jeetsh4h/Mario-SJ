using UnityEngine;

public class PopUpAnimation : MonoBehaviour
{
    [SerializeField] public CircleCollider2D signCollider; // Reference to the parent (Sign) Collider 2D
    public Animator animator;

    private void Start()
    {
        if (signCollider == null)
        {
            Debug.LogError("The 'signCollider' reference is not set. Please assign it in the Inspector.");
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == signCollider)
        {
            Debug.Log("Entered trigger zone");
            // Trigger your animation or do other actions here
            //animator.SetBool("isAnimating", true);
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == signCollider)
        {
            Debug.Log("Exited trigger zone");
            // Stop the animation or do other actions here
            //animator.SetBool("isAnimating", false);
        }
    }
}
