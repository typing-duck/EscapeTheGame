using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class MainMenuController : MonoBehaviour
{
    private MainMenuModel model;
    private MainMenuView view;

    private GameObject optionsTable;
    private GameObject frame;

    void Start()
    {
     model = GameObject.FindObjectOfType<MainMenuModel>();
     view = GameObject.FindObjectOfType<MainMenuView>();

     optionsTable = GameObject.Find("OptionsTable");
     frame = GameObject.Find("Frame");
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.DownArrow) && model.framePosition < model.maxPosition)
       {
         model.framePosition++;
         view.MoveFrame(frame, "down");
       } 
       if(Input.GetKeyDown(KeyCode.UpArrow) && model.framePosition > 0)
       {
         model.framePosition--;
         view.MoveFrame(frame, "up");
       }

       if(Input.GetKeyDown(KeyCode.Return))
       {
         if(model.GetMenuOption() == "Continue")
         {
           int index = CurrentSavedLevelIndex();
           if(index > 0)
           {
             SceneManager.LoadScene(index);
           }
           else
           {
            SceneManager.LoadScene(1);
           }
         }
         else if(model.GetMenuOption() == "NewGame")
         {
           SceneManager.LoadScene(1);
         }
         else if(model.GetMenuOption() == "Options")
         {
           view.ShowObject(optionsTable);
         }
         else if(model.GetMenuOption() == "Exit")
         {
           Application.Quit();
         }
       }
       if(Input.GetKeyDown(KeyCode.Escape))
       {
         view.HideObject(optionsTable);
       }
    }

    public int CurrentSavedLevelIndex()
    {
      using (TextReader reader = File.OpenText("SavedLevel.txt"))
      {
        return int.Parse(reader.ReadLine());
      }
    }
}
