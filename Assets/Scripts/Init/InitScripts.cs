using UnityEngine;
using System.Collections;
using System;
using UnityEngine.SceneManagement;
using System.IO;

public class InitScripts : MonoBehaviour 
{
    void Start ()
    {
      using (TextWriter writer = File.CreateText("SavedLevel.txt"))
      {
        writer.WriteLine(SceneManager.GetActiveScene().buildIndex);
      }

      GameObject controllers = new GameObject("Controllers");
      GameObject views = new GameObject("Views");
      
      Type[,] AllClasses = new Type[,] {
        {typeof(BulbModel), typeof(BulbView), typeof(BulbController)},
        {typeof(ButtonModel), typeof(ButtonView), typeof(ButtonController)},
        {typeof(ExitCheckModel), typeof(ExitCheckView), typeof(ExitCheckController)},
        {typeof(GameMenuModel), typeof(GameMenuView), typeof(GameMenuController)},
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