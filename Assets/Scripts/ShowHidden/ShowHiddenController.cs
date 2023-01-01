using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenController : MonoBehaviour
{
  private ShowHiddenModel model;
  private ShowHiddenView view;

  void Start()
  {
   model = gameObject.GetComponent<ShowHiddenModel>();
   view = gameObject.GetComponent<ShowHiddenView>();
  }

  void Update()
  {
    view.MoveToLayer(model.spriteRenderer, 0);
    if(model.switcherOn1??true)
      {
       if(model.switcherOn1.GetComponent<SwitchModel>().isOn)
         {
          if(model.switcherOn2??true)
            {
             if(model.switcherOn2.GetComponent<SwitchModel>().isOn)
               {
                view.MoveToLayer(model.spriteRenderer, model.layerToMove);
               }
            }
          else
            {
             view.MoveToLayer(model.spriteRenderer, model.layerToMove);
            }
         }   
      }
  }
}
