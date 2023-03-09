using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BaseModel : MonoBehaviour
{
  public Collider2D triggerCollision = null;
  public bool isInRange = false;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    triggerCollision = collision;
  }

  private void OnTriggerExit2D(Collider2D collision)
  {
    triggerCollision = collision;
  }
}
