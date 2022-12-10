using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckController : IsEnd
{
    private PositionCheckModel positionCheckModel;

    void Start()
    {
      positionCheckModel = GetComponent<PositionCheckModel>();
    }

    override public bool Done()
    {
      return positionCheckModel.correctPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
      if(collision.transform.position == positionCheckModel.target.transform.position)
      {
       positionCheckModel.correctPosition = true;
	     Debug.Log("Object at target position");
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
     {
      if(collision.transform.position == positionCheckModel.target.transform.position)
      {
       positionCheckModel.correctPosition = false;
	     Debug.Log("Object not at target position");
      }
     }
}
