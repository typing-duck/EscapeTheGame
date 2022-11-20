using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheck : MonoBehaviour
{

  public GameObject switcher;
  public GameObject[] objects_to_move;
  public int howManyObjectToMove;
  public bool isEnd;
  public Sprite doorOpen;
  public Sprite doorClose;

  void Start()
  {
   isEnd = false;
   howManyObjectToMove = objects_to_move.Length;
  }

  void Update()
  {
   if(isEnd)
   {
	  GetComponent<SpriteRenderer>().sprite = doorOpen;
   }
   else
   {
    GetComponent<SpriteRenderer>().sprite = doorClose;
   }
   isEnd = true;
   if(switcher??true)
   {
    if(switcher.GetComponent<SwitchController>().isOn == false)
	  {
	   isEnd = false;
	  }
   }
   if(howManyObjectToMove > 0)
   {
    for(int i=0; i < howManyObjectToMove; i++)
    {
     if(objects_to_move[i].GetComponent<PositionCheck>().correctPosition == false)
     {
      isEnd = false;
     }
    }
   }
}
}
