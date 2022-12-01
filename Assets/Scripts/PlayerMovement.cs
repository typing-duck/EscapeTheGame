using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    public GameObject blackoutSwitcher;

    void Update()
    {
       if(blackoutSwitcher??true)
       {
        if(blackoutSwitcher.GetComponent<SwitchModel>().isOn == true)
        {
          return;
        }
       }
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
