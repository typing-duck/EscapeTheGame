using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : IsEnd
{
   private SwitchModel switchModel;

   void Start()
   {
    switchModel = GetComponent<SwitchModel>();
   }

   override public bool Done()
    {
      if(switchModel.isPositionImportant == true)
      {
       return switchModel.isOn == switchModel.shouldBeOn;
      }
      return true;
    }
   
   public void Switch()
   {
     switchModel.isOn = !switchModel.isOn;
     Debug.Log("Change");
   }
}
