using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckController : MonoBehaviour
{
  private ExitCheckModel exitCheckModel;
  private ExitCheckView exitCheckView;
  private GameObject door;

  void Start()
  {
   exitCheckModel = GameObject.FindObjectOfType<ExitCheckModel>();
   exitCheckView = GameObject.FindObjectOfType<ExitCheckView>();
   door = GameObject.FindGameObjectWithTag("Door");
  }

  void Update()
  {
   if(exitCheckModel.nextLevel == true)
   {
    exitCheckView.LoadNextLevel();
   }

   exitCheckView.ChangeSprite(door.GetComponent<SpriteRenderer>(), exitCheckModel.doorClose);
   if(exitCheckModel.openExit)
   {
	  exitCheckView.ChangeSprite(door.GetComponent<SpriteRenderer>(), exitCheckModel.doorOpen);
   }
   exitCheckModel.openExit = true;
   foreach(IsEnd obj in exitCheckModel.allObjects)
   {
    if(obj.Done() == false)
    {
      exitCheckModel.openExit = false;
      break;
    }
   }
  }
}
