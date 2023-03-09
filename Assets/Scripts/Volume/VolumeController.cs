using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeController : MonoBehaviour
{
  private VolumeModel model;
  private VolumeView view;

  void Start()
  {
   model = GameObject.FindObjectOfType<VolumeModel>();
   view = GameObject.FindObjectOfType<VolumeView>();
  }

    void Update()
    {
       view.ChangeColorFilter(model.currentColorAdjustments, view.white);
       int many = 0;
       foreach(GameObject switcher in model.colorSwitchers)
       {
         if(switcher.GetComponent<SwitchModel>().isOn == true)
           {
            if(switcher.tag.Contains("Grey"))
              {
               many++;
               view.ChangeColorFilter(model.currentColorAdjustments, view.grey);
              }
            if(switcher.tag.Contains("Pink"))
              {
               many++;
               view.ChangeColorFilter(model.currentColorAdjustments, view.pink);
              }
            if(many == 2)
              {
               view.ChangeColorFilter(model.currentColorAdjustments, view.blended_purple);
              }
           }
       }
    }
}


