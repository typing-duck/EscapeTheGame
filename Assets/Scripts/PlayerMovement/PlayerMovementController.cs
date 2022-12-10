using UnityEngine;

public class PlayerMovementController : MonoBehaviour
{
    private PlayerMovementModel playerMovementModel;
    private PlayerMovementView playerMovementView;

    void Start()
    {
      playerMovementModel = GetComponent<PlayerMovementModel>();
      playerMovementView = GetComponent<PlayerMovementView>();
    }

    void Update()
    {
      
      foreach(GameObject switcher in playerMovementModel.blackoutSwitchers)
       {
        if(switcher.GetComponent<SwitchModel>().isOn == true)
        {
          return;
        }
       }
       if(playerMovementModel.movement.y < 0.01 && playerMovementModel.movement.y > -0.01) //add abs
       {
        playerMovementModel.movement.x = Input.GetAxisRaw("Horizontal");
       }
       if(playerMovementModel.movement.x < 0.01 && playerMovementModel.movement.x > -0.01) //add abs
       {
        playerMovementModel.movement.y = Input.GetAxisRaw("Vertical");
       }
       playerMovementView.ChangeAnimator(playerMovementModel.animator, "Horizontal", playerMovementModel.movement.x);
       playerMovementView.ChangeAnimator(playerMovementModel.animator, "Vertical", playerMovementModel.movement.y);
       playerMovementView.ChangeAnimator(playerMovementModel.animator, "Speed", playerMovementModel.movement.sqrMagnitude);
    }

    void FixedUpdate()
    {
     playerMovementModel.rb.MovePosition(playerMovementModel.rb.position + playerMovementModel.movement * playerMovementModel.MoveSpeed * Time.fixedDeltaTime);
    }
}
