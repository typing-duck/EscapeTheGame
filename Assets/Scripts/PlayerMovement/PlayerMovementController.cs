using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerMovementModel model;
    private PlayerMovementView view;

    public float normalMoveSpeed = 1f;
    public float fasterMoveSpeed =  2f;
    public float currentMoveSpeed;
    public KeyCode fasterKey = KeyCode.LeftShift;

    void Start()
    {
     model = GameObject.FindObjectOfType<PlayerMovementModel>();
     view = GameObject.FindObjectOfType<PlayerMovementView>();
     currentMoveSpeed = normalMoveSpeed;
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
      if(Input.GetKey(fasterKey))
      {
        currentMoveSpeed = fasterMoveSpeed;
      }
      else
      {
        currentMoveSpeed = normalMoveSpeed;
      }
     model.rb.MovePosition(model.rb.position + model.movement * currentMoveSpeed * Time.fixedDeltaTime);
    }
}
