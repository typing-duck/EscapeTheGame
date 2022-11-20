using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchController : MonoBehaviour
{
   public bool isOn = false;
   
   public void Switch()
   {
     isOn = !isOn;
     Debug.Log("Change");
   }
}
