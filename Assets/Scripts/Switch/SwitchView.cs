using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchView : BaseView
{
  public Sprite switchOn;
  public Sprite switchOff;

  void Start()
  {
    switchOn = Resources.Load<Sprite>("switch_on");
    switchOff = Resources.Load<Sprite>("switch_off");
  }
}
