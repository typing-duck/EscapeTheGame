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
     view.MoveToLayer(model, 0);
     if(model.switcherOn1??true)
      {
       if(model.switcherOn1.GetComponent<SwitchModel>().isOn)
         {
          if(model.switcherOn2??true)
            {
             if(model.switcherOn2.GetComponent<SwitchModel>().isOn)
               {
                view.MoveToLayer(model, model.layerToMove);
               }
            }
          else
            {
             view.MoveToLayer(model, model.layerToMove);
            }
         }   
      }
    }
  }
}
