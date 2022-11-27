using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeController : MonoBehaviour
{
    public GameObject[] colorSwitchers;
    private Color32[] colorPalette = {new Color32(111,111,111,255), new Color32(255,170,255,255)};
    private Color32 white = new Color32(255, 255, 255, 255);
    private Color32 blended = new Color32(125, 65, 140, 255);
    private Volume currentVolume;
    private ColorAdjustments currentColorAdjustments;
    // Start is called before the first frame update
    void Start()
    {
      currentVolume = GetComponent<Volume>();
      currentVolume.profile.TryGet(out currentColorAdjustments);
    }

    // Update is called once per frame
    void Update()
    {
      currentColorAdjustments.colorFilter.value = white;
      for(int i = 0; i < colorSwitchers.Length; i++)
      {
        if(colorSwitchers[i].GetComponent<SwitchController>().isOn == true)
        {
          currentColorAdjustments.colorFilter.value = colorPalette[i];
        }
      }
      if(colorSwitchers[0].GetComponent<SwitchController>().isOn == true && colorSwitchers[1].GetComponent<SwitchController>().isOn == true)
      {
        currentColorAdjustments.colorFilter.value = blended;
      }
    }
}


