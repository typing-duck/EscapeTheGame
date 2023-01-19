using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckModel : MonoBehaviour
{
    [HideInInspector] 
    public bool correctPosition = false;
    public GameObject target;
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
