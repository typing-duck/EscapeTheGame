using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BaseView : MonoBehaviour
{
  private void ChangeSprite(GameObject object, Sprite new_sprite)
  {
    object.GetComponent<SpriteRenderer>().sprite = new_sprite;
  }
}
