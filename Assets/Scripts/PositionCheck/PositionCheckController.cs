using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckController : IsEnd
{
    private PositionCheckModel[] models;

    void Start()
    {
      models = GameObject.FindObjectsOfType<PositionCheckModel>();
    }

    void Update()
    {
     foreach(PositionCheckModel model in models)
      {
        if(model.triggerCollision)
        {
          HandleCollision(model);
        }
      }
    }

    override public bool Done()
    {
      foreach(PositionCheckModel model in models)
      {
       if(model.correctPosition == false)
       {
        return false;
       }
      }
      return true;
    }

    private void HandleCollision(PositionCheckModel model)
     {
    if(model.triggerCollision.transform.position == model.target.transform.position)
      {
        model.correctPosition = !model.correctPosition;
        if(model.correctPosition == true)
        {
         Debug.Log("Object at target position");
        }
        else
        {
          Debug.Log("Object not at target position");
        }
      }
    model.triggerCollision = null;
  }
}
