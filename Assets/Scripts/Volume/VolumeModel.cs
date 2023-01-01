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

    public List<GameObject> colorSwitchers = new List<GameObject>();

    private Volume currentVolume;
    [HideInInspector] 
    public ColorAdjustments currentColorAdjustments;

    void Start()
    {
      gameObject.AddComponent<VolumeController>();
      gameObject.AddComponent<VolumeView>();

      currentVolume = GetComponent<Volume>();
      currentVolume.profile.TryGet(out currentColorAdjustments);

      GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
      foreach(GameObject obj in allObjects)
      {
        if(obj.tag.Contains("Color"))
        {
          colorSwitchers.Add(obj);
        }
      }
    }

}