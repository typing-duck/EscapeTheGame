using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbController : MonoBehaviour
{
  private BulbModel[] models;
  private BulbView view;

  private bool allSwitchesOn = false;

  void Start()
  {
   models = GameObject.FindObjectsOfType<BulbModel>();
   view = GameObject.FindObjectOfType<BulbView>();
  }

  void Update()
  {
   foreach(BulbModel model in models)
   {
    allSwitchesOn = true;
    foreach(GameObject switcher in model.switchers)
    {
       if(switcher.GetComponent<SwitchModel>().isOn == false)
       {
        allSwitchesOn = false;
        break;
       }
     }
     if(allSwitchesOn == true)
     {
      view.ChangeSprite(model.gameObject, view.bulbOn);
     }
     else
     {
      view.ChangeSprite(model.gameObject, view.bulbOff);
     }
    }
  }
}