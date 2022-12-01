using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeController : MonoBehaviour
{
    private VolumeModel volumeModel;
    private VolumeView volumeView;
   
   void Start()
   {
    volumeModel = GameObject.FindObjectOfType<VolumeModel>();
    volumeView = GameObject.FindObjectOfType<VolumeView>();
   }

    // Update is called once per frame
    void Update()
    {
      volumeView.ChangeColorFilter(volumeModel.currentColorAdjustments, volumeModel.white);
      /*
      for(int i = 0; i < volumeModel.colorSwitchers.Length; i++)
      {
        if(volumeModel.colorSwitchers[i].GetComponent<SwitchController>().isOn == true)
        {
          volumeView.ChangeColorFilter(volumeModel.currentColorAdjustments, volumeModel.colorPalette[i]);
        }
      }
      */
      if(volumeModel.colorSwitchers[0].GetComponent<SwitchModel>().isOn == true)
      {
        volumeView.ChangeColorFilter(volumeModel.currentColorAdjustments, volumeModel.grey);
      }
      if(volumeModel.colorSwitchers[1].GetComponent<SwitchModel>().isOn == true)
      {
        volumeView.ChangeColorFilter(volumeModel.currentColorAdjustments, volumeModel.pink);
      }
      if(volumeModel.colorSwitchers[0].GetComponent<SwitchModel>().isOn == true && volumeModel.colorSwitchers[1].GetComponent<SwitchModel>().isOn == true)
      {
        volumeView.ChangeColorFilter(volumeModel.currentColorAdjustments, volumeModel.blended);
      }
    }
}


