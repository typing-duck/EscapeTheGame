using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbView : BaseView
{
  public Sprite bulbOn;
  public Sprite bulbOff;

  public void SpriteBulbOn(BulbModel model, bool state)
  {
   if(state == true)
   {
    ChangeSprite(model, bulbOn);
   }
   else
   {
    ChangeSprite(model, bulbOff);
   }
  }
}
