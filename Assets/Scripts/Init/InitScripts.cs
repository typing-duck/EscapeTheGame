using UnityEngine;
using System.Collections;
using System;

public class InitScripts : MonoBehaviour 
{
    void Start ()
    {
      GameObject controllers = GameObject.Find("Controllers");
      GameObject views = GameObject.Find("Views");
      Type[,] AllClasses = new Type[,] {
        {typeof(BulbModel), typeof(BulbView), typeof(BulbController)},
        {typeof(ButtonModel), typeof(ButtonView), typeof(ButtonController)},
        {typeof(ExitCheckModel), typeof(ExitCheckView), typeof(ExitCheckController)},
        {typeof(LetterModel), typeof(LetterView), typeof(LetterController)},
        {typeof(PlayerMovementModel), typeof(PlayerMovementView), typeof(PlayerMovementController)},
        {typeof(PositionCheckModel), typeof(PositionCheckView), typeof(PositionCheckController)},
        {typeof(ShowHiddenModel), typeof(ShowHiddenView), typeof(ShowHiddenController)},
        {typeof(SwitchModel), typeof(SwitchView), typeof(SwitchController)},
        {typeof(VolumeModel), typeof(VolumeView), typeof(VolumeController)}
        };

      for(int row=0; row<AllClasses.GetLength(0); row++)
      {
        if(GameObject.FindObjectOfType(AllClasses[row,0]) != null)
        {
          views.AddComponent(AllClasses[row,1]);
          controllers.AddComponent(AllClasses[row,2]);
        }
      }
    }
}