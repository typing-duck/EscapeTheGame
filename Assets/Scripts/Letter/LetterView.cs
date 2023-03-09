using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LetterView : BaseView
{
  public void ChangeSpriteColor(GameObject obj, Color32 new_color)
  {
    obj.GetComponent<SpriteRenderer>().color = new_color;
  }
}
