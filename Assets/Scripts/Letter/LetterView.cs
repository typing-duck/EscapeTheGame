using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterView : BaseView
{
  public Color32 yellow = new Color32(255,190,0,255);
  public Color32 white = new Color32(255,255,255,255);
  public Color32 black = new Color32(0,0,0,255);

  public void ChangeSpriteColor(GameObject obj, Color32 new_color)
  {
    obj.GetComponent<SpriteRenderer>().color = new_color;
  }
}
