using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbView : BaseView
{
  public Sprite bulbOn;
  public Sprite bulbOff;

  void Start()
  {
    bulbOn = Resources.Load<Sprite>("bulb_on");
    bulbOff = Resources.Load<Sprite>("bulb_off");
  }
}
