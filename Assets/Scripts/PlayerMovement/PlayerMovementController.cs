using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerMovementModel model;
    private PlayerMovementView view;

    void Start()
    {
     model = GameObject.FindObjectOfType<PlayerMovementModel>();
     view = GameObject.FindObjectOfType<PlayerMovementView>();
    }

    void Update()
    {
      foreach(GameObject switcher in model.blackoutSwitchers)
       {
        if(switcher.GetComponent<SwitchModel>().isOn == true)
        {
          return;
        }
       }
       if(model.movement.y < 0.01 && model.movement.y > -0.01) //add abs
       {
        model.movement.x = Input.GetAxisRaw("Horizontal");
       }
       if(model.movement.x < 0.01 && model.movement.x > -0.01) //add abs
       {
        model.movement.y = Input.GetAxisRaw("Vertical");
       }
       view.ChangeAnimator(model.animator, "Horizontal", model.movement.x);
       view.ChangeAnimator(model.animator, "Vertical", model.movement.y);
       view.ChangeAnimator(model.animator, "Speed", model.movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
     foreach(GameObject switcher in model.blackoutSwitchers)
       {
        if(switcher.GetComponent<SwitchModel>().isOn == true)
        {
          return;
        }
       }
     model.rb.MovePosition(model.rb.position + model.movement * model.MoveSpeed * Time.fixedDeltaTime);
    }
}
