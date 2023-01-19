using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbView : MonoBehaviour
{
  public Sprite bulbOn;
  public Sprite bulbOff;

  public void SpriteBulbOn(BulbModel model, bool state)
  {
   if(state == true)
   {
    model.gameObject.GetComponent<SpriteRenderer>().sprite = bulbOn;
   }
   else
   {
    model.gameObject.GetComponent<SpriteRenderer>().sprite = bulbOff;
   }
  }
}
