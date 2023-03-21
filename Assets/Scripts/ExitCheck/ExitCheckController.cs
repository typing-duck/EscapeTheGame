using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckController : MonoBehaviour
{
  private ExitCheckModel model;
  private ExitCheckView view;
  private GameObject door;
  public IsEnd[] allEndObjects;

  void Start()
  {
   model = GameObject.FindObjectOfType<ExitCheckModel>();
   view = GameObject.FindObjectOfType<ExitCheckView>();
   door = GameObject.FindGameObjectWithTag("Door");
   allEndObjects = GameObject.FindObjectsOfType<IsEnd>();
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

   if(model.openExit)
   {
     view.ChangeSprite(door, view.doorOpen);
   }
   else
   {
     view.ChangeSprite(door, view.doorClose);
   }

   model.openExit = true;
   foreach(IsEnd obj in allEndObjects)
   {
    if(!obj.Done())
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
