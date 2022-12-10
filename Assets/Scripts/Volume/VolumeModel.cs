using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeModel : MonoBehaviour
{
    public Color32 grey = new Color32(111,111,111,255);
    public Color32 pink = new Color32(255,170,255,255);
    public Color32 white = new Color32(255, 255, 255, 255);
    public Color32 blended = new Color32(125, 65, 140, 255);

    public GameObject[] colorSwitchers;
    //[HideInInspector]
    //public List<Color32> colorPalette = new List<Color32>(2);
    //public Color32[] colorPalette = new Color32[10];

    private Volume currentVolume;
    [HideInInspector] 
    public ColorAdjustments currentColorAdjustments;

    void Start()
    {
      currentVolume = GetComponent<Volume>();
      currentVolume.profile.TryGet(out currentColorAdjustments);
      //colorPalette[0] = grey;
      //colorPalette[1] = pink;
    }

}