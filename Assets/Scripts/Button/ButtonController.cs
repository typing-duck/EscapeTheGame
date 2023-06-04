using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : BaseController
{
  private ButtonModel[] models;

  void Start()
  {
   models = GameObject.FindObjectsOfType<ButtonModel>();
  }

  void Update()
    {
      foreach(ButtonModel model in models)
      {
        if(model.triggerCollision)
        {
          HandleCollision(model);
        }
        if(model.isInRange && actionKeyPressed())
        {
	        StartCoroutine(Press(model));   
        }
      }
    }
  
  IEnumerator Press(ButtonModel model)
   {
     model.isOn = true;
     Debug.Log("Button on.");
     yield return new WaitForSecondsRealtime(0.5f);
     model.isOn = false;
     Debug.Log("Button off.");
   }

  public void HandleCollision(ButtonModel model)
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
