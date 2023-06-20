using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationController : IsDone
{
  private RotationModel[] models; 
  private RotationView view;
  private List<SwitchModel> switchers = new List<SwitchModel>();
  private bool canRotate = false;
  private float timer = 0f;
  private float duration = 0f;
  private float targetDuration = 2f;

    void Start()
    {
      models = GameObject.FindObjectsOfType<RotationModel>();
      view = GameObject.FindObjectOfType<RotationView>();

      SwitchModel[] allSwitchers = UnityEngine.Object.FindObjectsOfType<SwitchModel>();
      foreach(SwitchModel switcher in allSwitchers)
      {
       if(switcher.gameObject.name.Contains("TurnRotation"))
       {
         switchers.Add(switcher);
       }
      }
    }

    void Update()
    {
      canRotate = true;
      foreach(SwitchModel switcher in switchers)
      {
        if(switcher.isOn == false)
        {
          canRotate = false;
          break;
        }
      }
      foreach(RotationModel model in models)
      {
        if(model.triggerCollision)
        {
          HandleCollision(model);
        }

        if(model.isInRange == true)
        {
         duration = Time.time - timer;
         if(duration >= targetDuration && canRotate)
         {
          model.rotationsTooFar = (model.rotationsTooFar + 1)%4;
          view.Rotate90(model.gameObject, model.rotationsTooFar);
          timer = Time.time;
         }
        }
      }
    }

    public void HandleCollision(RotationModel model)
    {
      if(model.triggerCollision.gameObject.CompareTag("Player"))
      {
        model.isInRange = !model.isInRange;
        if(model.isInRange == true)
        {
         Debug.Log("Player is in range");
         timer = Time.time;
        }
        else
        {
          Debug.Log("Player isn't in range");
        }
      }
      model.triggerCollision = null;
    }

    override public bool Done()
    {
        foreach(RotationModel model in models)
        {
          if(model.rotationsTooFar != 0)
          {
            return false;
          }
        }
        return true;
    }
}
