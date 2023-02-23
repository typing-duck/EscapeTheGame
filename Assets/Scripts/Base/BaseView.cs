using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BaseView : MonoBehaviour
{
  public void ChangeSprite(GameObject obj, Sprite newSprite)
  {
    obj.GetComponent<SpriteRenderer>().sprite = newSprite;
  }
}
