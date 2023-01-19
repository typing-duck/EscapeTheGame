using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbModel : MonoBehaviour
{
    public GameObject switcherAdd;

    void Update()
    {
      SwitchModel[] allSwitches = GameObject.FindObjectsOfType<SwitchModel>();
      foreach(SwitchModel switcher in allSwitches)
      {
        if(switcher.gameObject.tag.Contains("Add1") && tag.Contains("Add1"))
        {
          switcherAdd = switcher.gameObject;
        }
        else if(switcher.gameObject.tag.Contains("Add2") && tag.Contains("Add2"))
        {
          switcherAdd = switcher.gameObject;
        }
      }
    }
}