using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : IsEnd
{
  private SwitchModel[] models; 

  void Start()
  {
    models = GameObject.FindObjectsOfType<SwitchModel>();
  }

  override public bool Done()
    {
     foreach(SwitchModel model in models)
     {
      if(model.isPositionImportant == true && model.isOn != model.shouldBeOn)
      {
        return false;
      }
     }
     return true;
    }

  void Update()
    {
      foreach(SwitchModel model in models)
      {
        if(model.isInRange && interactKeyPressed())
        {
	        Switch(model);   
        }
        if(model.triggerCollision)
        {
          HandleCollision(model);
        }
      }
    }
  
  public void Switch(SwitchModel model)
   {
     model.isOn = !model.isOn;
     Debug.Log("Change");
   }

  public void HandleCollision(SwitchModel model)
  {
    if(model.triggerCollision.gameObject.CompareTag("Player"))
      {
        model.isInRange = !model.isInRange;
        if(model.isInRange == true)
        {
         Debug.Log("Player is in range");
        }
        else
        {
          Debug.Log("Player isn't in range");
        }
      }
    model.triggerCollision = null;
  }
}
