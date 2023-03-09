using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeView : BaseView
{
    public void ChangeColorFilter(ColorAdjustments colorAdjustments, Color32 newColor)
    {
      colorAdjustments.colorFilter.value = newColor;
    }
}
