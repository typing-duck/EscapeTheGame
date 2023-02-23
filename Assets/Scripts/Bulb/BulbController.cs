using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbController : MonoBehaviour
{
  private BulbModel[] models;
  private BulbView view;

  void Start()
  {
   models = GameObject.FindObjectsOfType<BulbModel>();
   view = GameObject.FindObjectOfType<BulbView>();
  }

  void Update()
  {
   foreach(BulbModel model in models)
   {
    if(model.switcherAdd != null)
    {
      if(model.switcherAdd.GetComponent<SwitchModel>().isOn == true)
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
}