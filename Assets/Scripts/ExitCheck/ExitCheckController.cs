using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckController : MonoBehaviour
{
  private ExitCheckModel model;
  private ExitCheckView view;
  public IsEnd[] allObjects;

  void Start()
  {
   model = GameObject.FindObjectOfType<ExitCheckModel>();
   view = GameObject.FindObjectOfType<ExitCheckView>();
   allObjects = GameObject.FindObjectsOfType<IsEnd>();
  }

  void Update()
  {
   if(model.triggerCollision)
   {
    HandleCollision();
   }
   if(model.nextLevel == true)
   {
    view.LoadNextLevel();
   }

   view.SpriteDoorOpen(false);
   if(model.openExit)
   {
	  view.SpriteDoorOpen(true);
   }
   model.openExit = true;
   foreach(IsEnd obj in allObjects)
   {
    if(obj.Done() == false)
    {
      model.openExit = false;
      break;
    }
   }
  }

  private void HandleCollision()
  {
    if(model.openExit == true && model.triggerCollision.tag == "Player")
    {
      model.nextLevel = true;
    }
    model.triggerCollision = null;
  }
}
