using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeController : MonoBehaviour
{
    private VolumeModel[] volumeModels;
    private VolumeView volumeView;
   
   void Start()
   {
    volumeModels = GameObject.FindObjectsOfType<VolumeModel>();
    volumeView = GameObject.FindObjectOfType<VolumeView>();
   }

    void Update()
    {
      foreach(VolumeModel model in volumeModels)
      {
       volumeView.ChangeColorFilter(model.currentColorAdjustments, model.white);
       if(model.colorSwitchers[0].GetComponent<SwitchModel>().isOn == true)
       {
         volumeView.ChangeColorFilter(model.currentColorAdjustments, model.grey);
       }
       if(model.colorSwitchers[1].GetComponent<SwitchModel>().isOn == true)
       {
         volumeView.ChangeColorFilter(model.currentColorAdjustments, model.pink);
       }
       if(model.colorSwitchers[0].GetComponent<SwitchModel>().isOn == true && model.colorSwitchers[1].GetComponent<SwitchModel>().isOn == true)
       {
         volumeView.ChangeColorFilter(model.currentColorAdjustments, model.blended);
       }
      }
    }
}


