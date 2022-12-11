using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenController : MonoBehaviour
{
    private ShowHiddenModel[] showHiddenModels;
    private ShowHiddenView showHiddenView;

    void Start()
    {
      showHiddenModels = GameObject.FindObjectsOfType<ShowHiddenModel>();
      showHiddenView = GameObject.FindObjectOfType<ShowHiddenView>();
    }

    void Update()
    {
      foreach(ShowHiddenModel model in showHiddenModels)
      {
       showHiddenView.MoveToLayer(model.spriteRenderer, 0);
       if(model.switcherOn1??true)
       {
        if(model.switcherOn1.GetComponent<SwitchModel>().isOn)
        {
          if(model.switcherOn2??true)
          {
           if(model.switcherOn2.GetComponent<SwitchModel>().isOn)
           {
            showHiddenView.MoveToLayer(model.spriteRenderer, model.layerToMove);
           }
          }
          else
          {
           showHiddenView.MoveToLayer(model.spriteRenderer, model.layerToMove);
          }
        }   
       }
      }
    }
}
