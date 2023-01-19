using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class VolumeModel : MonoBehaviour
{
    public List<GameObject> colorSwitchers = new List<GameObject>();

    private Volume currentVolume;
    [HideInInspector] 
    public ColorAdjustments currentColorAdjustments;

    void Start()
    {
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