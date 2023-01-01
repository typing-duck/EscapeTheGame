using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckController : MonoBehaviour
{
  private ExitCheckModel model;
  private ExitCheckView view;
  private GameObject door;

  void Start()
  {
   model = gameObject.GetComponent<ExitCheckModel>();
   view = gameObject.GetComponent<ExitCheckView>();
   door = GameObject.FindGameObjectWithTag("Door");
  }

  void Update()
  {
   if(model.nextLevel == true)
   {
    view.LoadNextLevel();
   }

   view.ChangeSprite(door.GetComponent<SpriteRenderer>(), model.doorClose);
   if(model.openExit)
   {
	  view.ChangeSprite(door.GetComponent<SpriteRenderer>(), model.doorOpen);
   }
   model.openExit = true;
   foreach(IsEnd obj in model.allObjects)
   {
    if(obj.Done() == false)
    {
      model.openExit = false;
      break;
    }
   }
  }
}
