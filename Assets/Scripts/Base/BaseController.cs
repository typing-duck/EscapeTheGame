using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BaseController : MonoBehaviour
{
  private List<KeyCode> actionKeys = new List<KeyCode> {KeyCode.E, KeyCode.Space};

  public bool actionKeyPressed()
  {
     foreach(KeyCode key in actionKeys)
     {
        if(Input.GetKeyDown(key))
        {
            return true;
        }
     }
     return false;
  }
}