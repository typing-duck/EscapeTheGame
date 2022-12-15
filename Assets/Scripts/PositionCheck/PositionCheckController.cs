using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckController : IsEnd
{
    private PositionCheckModel[] positionCheckModels;

    void Start()
    {
      positionCheckModels = GameObject.FindObjectsOfType<PositionCheckModel>();
    }

    override public bool Done()
    {
      bool result = true;
      foreach(PositionCheckModel model in positionCheckModels)
      {
        if(model.correctPosition == false)
        {
          result = false;
        }
      }
      return result;
    }
}
