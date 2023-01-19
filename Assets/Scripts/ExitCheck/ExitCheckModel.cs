using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckModel : MonoBehaviour
{
  public bool openExit = false;
  public bool nextLevel = false;
  public Collider2D triggerCollision = null;

  private void OnTriggerEnter2D(Collider2D collision)
  {
    triggerCollision = collision;
  }

}