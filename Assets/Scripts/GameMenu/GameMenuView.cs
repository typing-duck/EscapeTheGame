using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMenuView : BaseView
{  
  public void MoveFrame(GameObject border, string direction)
  {
    if(direction == "up")
    {
      border.transform.position = border.transform.position + new Vector3(0,0.5f,0);
    }
    else if(direction == "down")
    {
     border.transform.position = border.transform.position - new Vector3(0,0.5f,0);
    }
  }
}
