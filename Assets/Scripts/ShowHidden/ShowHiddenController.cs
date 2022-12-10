using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenController : MonoBehaviour
{
    private ShowHiddenModel showHiddenModel;
    private ShowHiddenView showHiddenView;
    private SpriteRenderer spriteRenderer;

    void Start()
    {
      showHiddenModel = GetComponent<ShowHiddenModel>();
      showHiddenView = GetComponent<ShowHiddenView>();
      spriteRenderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
     showHiddenView.MoveToLayer(spriteRenderer, 0);
     if(showHiddenModel.switcherOn1??true)
     {
      if(showHiddenModel.switcherOn1.GetComponent<SwitchModel>().isOn)
      {
        if(showHiddenModel.switcherOn2??true)
        {
         if(showHiddenModel.switcherOn2.GetComponent<SwitchModel>().isOn)
         {
          showHiddenView.MoveToLayer(spriteRenderer, showHiddenModel.layerToMove);
         }
        }
        else
        {
         showHiddenView.MoveToLayer(spriteRenderer, showHiddenModel.layerToMove);
        }
      }  
     }
    }
}
