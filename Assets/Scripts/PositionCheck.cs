using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheck : IsEnd
{
    public bool correctPosition;
    public GameObject target;
    override public bool Done()
    {
      return correctPosition;
    }

    void Start()
    {
     correctPosition = false;    
    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
      if(collision.transform.position == target.transform.position)
      {
       correctPosition = true;
	     Debug.Log("Object at target position");
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
     {
      if(collision.transform.position == target.transform.position)
      {
       correctPosition = false;
	     Debug.Log("Object not at target position");
      }
     }
}
