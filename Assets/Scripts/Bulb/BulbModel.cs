using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbModel : MonoBehaviour
{
    public GameObject switcherAdd;

    void Start()
    {
      GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
      foreach(GameObject obj in allObjects)
      {
        if(obj.tag.Contains("Add1") && tag.Contains("Add1"))
        {
          switcherAdd = obj;
        }
        else if(obj.tag.Contains("Add2") && tag.Contains("Add2"))
        {
            switcherAdd = obj;
        }
      }
    }
}