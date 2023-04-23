using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuView : MonoBehaviour
{
  public void MoveBorder(GameObject border, string direction)
  {
    if(direction == "up")
    {
      border.transform.position = border.transform.position + new Vector3(0,1,0);
    }
    else if(direction == "down")
    {
     border.transform.position = border.transform.position - new Vector3(0,1,0);
    }
  }

  public void ShowTable(GameObject table, bool open)
  {
    SpriteRenderer spriteRenderer = table.GetComponent<SpriteRenderer>();
    if(open == true)
    {
      spriteRenderer.sortingOrder = 2;
    }
    else
    {
      spriteRenderer.sortingOrder = 0;
    }
  }
}
