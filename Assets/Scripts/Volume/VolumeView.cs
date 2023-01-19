using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeView : MonoBehaviour
{
    public Color32 grey = new Color32(111,111,111,255);
    public Color32 pink = new Color32(255,170,255,255);
    public Color32 white = new Color32(255, 255, 255, 255);
    public Color32 blended = new Color32(125, 65, 140, 255);

    public void ChangeColorFilter(ColorAdjustments colorAdjustments, Color32 newColor)
    {
      colorAdjustments.colorFilter.value = newColor;
    }
}
