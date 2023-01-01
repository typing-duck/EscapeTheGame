using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : IsEnd
{
  private SwitchModel model;

  void Start()
    {
      model = gameObject.AddComponent<SwitchModel>();
    }

  override public bool Done()
    {
     if(model.isPositionImportant == true && model.isOn != model.shouldBeOn)
        {
         return false;
        }
     return true;
    }
   
  public void Switch()
   {
     model.isOn = !model.isOn;
     Debug.Log("Change");
   }
}
