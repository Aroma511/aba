using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour

{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    public Animator animator;
   

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
    
    void Update()
    {
        if (movement.y > 0)
        {
            animator.Play("walking_up");
        }
        else if (movement.y < 0)
        {
            animator.Play("walking_down");
        }
        else if (movement.x > 0)
        {
            animator.Play("walking_right");
        }
        else if (movement.x < 0)
        {
            animator.Play("walking_left");
        }
        else
        {
            animator.Play("player_Stable");
        }
        
    }
    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}
