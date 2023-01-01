using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : IsEnd
{
  private SwitchModel model;

  void Start()
  {
   model = gameObject.GetComponent<SwitchModel>();
  }
  override public bool Done()
    {
     if(model.isPositionImportant == true && model.isOn != model.shouldBeOn)
        {
         return false;
        }
     return true;
    }

  void Update()
    {
        if(model.isInRange)
        {
          if(Input.GetKeyDown(model.interactKey))
	          {
	           Switch();
	          }
        }
    }
  
  public void Switch()
   {
     model.isOn = !model.isOn;
     Debug.Log("Change");
   }

  private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("Player"))
      {
        model.isInRange = true;
	      Debug.Log("Player is in range");
      }
    }

  private void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("Player"))
      {
        model.isInRange = false;
	      Debug.Log("Player is not in range");
      }
    }
}
