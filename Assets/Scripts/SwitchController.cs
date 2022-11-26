using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : IsEnd
{
   public bool isOn = false;
   public bool isPositionImportant = false;
   public bool shouldBeOn = true;

   override public bool Done()
    {
      if(isPositionImportant == true)
      {
       return isOn == shouldBeOn;
      }
      return true;
    }
   
   public void Switch()
   {
     isOn = !isOn;
     Debug.Log("Change");
   }
}
