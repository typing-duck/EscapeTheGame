using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckView : MonoBehaviour
{
  public void ChangeSprite(SpriteRenderer spriteRenderer, Sprite newSprite)
  {
   spriteRenderer.sprite = newSprite;
  }
}