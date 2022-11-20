using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;

    void Update()
    {
       if(movement.y < 0.01 && movement.y > -0.01) //add abs
       {
        movement.x = Input.GetAxisRaw("Horizontal");
       }
       if(movement.x < 0.01 && movement.x > -0.01) //add abs
       {
        movement.y = Input.GetAxisRaw("Vertical");
       }

       animator.SetFloat("Horizontal", movement.x);
       animator.SetFloat("Vertical", movement.y);
       animator.SetFloat("Speed", movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
     rb.MovePosition(rb.position + movement * MoveSpeed * Time.fixedDeltaTime);
    }
}
