using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonModel : MonoBehaviour
{
   public bool isOn = false;
   public bool isInRange = false;

   public Collider2D triggerCollision = null;

   private void OnTriggerEnter2D(Collider2D collision)
    {
     triggerCollision = collision;
    }

   private void OnTriggerExit2D(Collider2D collision)
    {
     triggerCollision = collision;
    }
}
