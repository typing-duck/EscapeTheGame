using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHidden : MonoBehaviour
{
    public GameObject switcherOn1;
    public GameObject switcherOn2;
    public int layerToMove = 2;

    void Update()
    {
     GetComponent<SpriteRenderer>().sortingOrder = 0;
     if(switcherOn1??true)
     {
      if(switcherOn1.GetComponent<SwitchModel>().isOn)
      {
        if(switcherOn2??true)
        {
         if(switcherOn2.GetComponent<SwitchModel>().isOn)
         {
          GetComponent<SpriteRenderer>().sortingOrder = layerToMove;
         }
        }
        else
        {
         GetComponent<SpriteRenderer>().sortingOrder = layerToMove; 
        }
      }  
     }
    }
}
