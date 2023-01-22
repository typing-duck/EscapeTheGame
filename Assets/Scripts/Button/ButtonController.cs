using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonController : MonoBehaviour
{
  private ButtonModel[] models;
  public KeyCode interactKey = KeyCode.E; 

  void Start()
  {
   models = GameObject.FindObjectsOfType<ButtonModel>();
  }

  void Update()
    {
      foreach(ButtonModel model in models)
      {
        if(model.isInRange && Input.GetKeyDown(interactKey))
        {
	        StartCoroutine(Press(model));   
        }
        if(model.triggerCollision)
        {
          HandleCollision(model);
        }
      }
    }
  
  IEnumerator Press(ButtonModel model)
   {
     model.isOn = true;
     Debug.Log("Button on.");
     yield return new WaitForSecondsRealtime(2);
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
