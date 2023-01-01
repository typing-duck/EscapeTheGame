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
   model = gameObject.GetComponent<VolumeModel>();
   view = gameObject.GetComponent<VolumeView>();
  }

    void Update()
    {
       Color32 grey = model.grey;
       view.ChangeColorFilter(model.currentColorAdjustments, model.white);
       int many = 0;
       foreach(GameObject switcher in model.colorSwitchers)
       {
         if(switcher.GetComponent<SwitchModel>().isOn == true)
           {
            if(switcher.tag.Contains("Grey"))
              {
               many++;
               view.ChangeColorFilter(model.currentColorAdjustments, model.grey);
              }
            if(switcher.tag.Contains("Pink"))
              {
               many++;
               view.ChangeColorFilter(model.currentColorAdjustments, model.pink);
              }
            if(many == 2)
              {
               view.ChangeColorFilter(model.currentColorAdjustments, model.blended);
              }
           }
       }
    }
}


