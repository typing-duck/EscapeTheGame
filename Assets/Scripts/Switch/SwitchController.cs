using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : IsEnd
{
   override public bool Done()
    {
      SwitchModel[] switchModels = GameObject.FindObjectsOfType<SwitchModel>();
      foreach(SwitchModel model in switchModels)
      {
       if(model.isPositionImportant == true && model.isOn != model.shouldBeOn)
         {
          return false;
         }
      }
      return true;
    }
   
   public void Switch(SwitchModel switchModel)
   {
     switchModel.isOn = !switchModel.isOn;
     Debug.Log("Change");
   }
}
