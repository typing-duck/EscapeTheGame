using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BulbController : MonoBehaviour
{
  private BulbModel model;
  private BulbView view;

  void Start()
  {
   model = gameObject.GetComponent<BulbModel>();
   view = gameObject.GetComponent<BulbView>();
  }

  void Update()
  {
    if(model.switcherAdd.GetComponent<SwitchModel>().isOn == true)
    {
      view.ChangeSprite(GetComponent<SpriteRenderer>(), model.bulbOn);
    }
    else
    {
      view.ChangeSprite(GetComponent<SpriteRenderer>(), model.bulbOff);
    }
  }
}