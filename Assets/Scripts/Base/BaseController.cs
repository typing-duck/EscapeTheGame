using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BaseController : MonoBehaviour
{
  private List<KeyCode> interactKeys = new List<KeyCode> {KeyCode.E, KeyCode.Space};

  public bool interactKeyPressed()
  {
     foreach(KeyCode key in interactKeys)
     {
        if(Input.GetKeyDown(key))
        {
            return true;
        }
     }
     return false;
  }
}