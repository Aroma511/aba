using UnityEngine;
using UnityEngine.InputSystem;
public class PlayerMovement : MonoBehaviour

{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;
    private Vector2 movement;

    void Start() 
    {
        rb = GetComponent<Rigidbody2D>();
    } 

    public void OnMove(InputAction.CallbackContext context)
    {
        movement = context.ReadValue<Vector2>();
    }
    
    void FixedUpdate()
    {
        rb.linearVelocity = movement * moveSpeed;
    }
}
