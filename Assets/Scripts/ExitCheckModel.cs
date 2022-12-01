using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckModel : MonoBehaviour
{
  public bool openExit;
  public Sprite doorOpen;
  public Sprite doorClose;
  [HideInInspector] 
  public IsEnd[] allObjects;

  void Start()
  {
   openExit = false;
   allObjects = GameObject.FindObjectsOfType<IsEnd>();
  }
}