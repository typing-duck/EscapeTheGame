using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbView : MonoBehaviour
{
  public void ChangeSprite(SpriteRenderer spriteRenderer, Sprite newSprite)
  {
   spriteRenderer.sprite = newSprite;
  }
}
