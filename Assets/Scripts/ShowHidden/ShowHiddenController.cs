using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenController : MonoBehaviour
{
  private ShowHiddenModel[] models;
  private ShowHiddenView view;

  void Start()
  {
   models = GameObject.FindObjectsOfType<ShowHiddenModel>();
   view = GameObject.FindObjectOfType<ShowHiddenView>();
  }

  void Update()
  {
    foreach(ShowHiddenModel model in models)
    {
     view.MoveToLayer(model, model.layerToMove);
     foreach(GameObject switcher in model.switchers)
     {
      if(switcher.GetComponent<SwitchModel>().isOn == false)
      {
        view.MoveToLayer(model, 0);
        break;
      }
     }
    }
  }
}
