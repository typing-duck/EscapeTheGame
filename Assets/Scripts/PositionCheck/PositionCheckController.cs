using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckController : IsEnd
{
    private PositionCheckModel model;

    void Start()
    {
      model = gameObject.GetComponent<PositionCheckModel>();
    }

    override public bool Done()
    {
      return model.correctPosition;
    }

    private void OnTriggerEnter2D(Collider2D collision)
     {
      if(collision.transform.position == model.target.transform.position)
      {
       model.correctPosition = true;
	     Debug.Log("Object at target position");
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
     {
      if(collision.transform.position == model.target.transform.position)
      {
       model.correctPosition = false;
	     Debug.Log("Object not at target position");
      }
     }
}
