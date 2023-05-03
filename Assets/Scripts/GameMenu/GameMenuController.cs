using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;

public class GameMenuController : MonoBehaviour
{
    private GameMenuModel model;
    private GameMenuView view;

    private PlayerMovementModel playerModel;

    private GameObject menu;
    private GameObject frame;

    void Start()
    {
     model = GameObject.FindObjectOfType<GameMenuModel>();
     view = GameObject.FindObjectOfType<GameMenuView>();

     playerModel = GameObject.FindObjectOfType<PlayerMovementModel>();

     menu = GameObject.Find("PausedMenu");
     frame = GameObject.Find("Frame");

     view.HideObject(menu);
    }

    void Update()
    {  
       if(Input.GetKeyDown(KeyCode.Return))
       {
         if(model.GetMenuOption() == "Replay")
         {
           SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
         }
         else if(model.GetMenuOption() == "MainMenu")
         {
           SceneManager.LoadScene(0);
         }
       }
       if(Input.GetKeyDown(KeyCode.Escape))
       {
         playerModel.canMove = !playerModel.canMove;
         view.ChangeObjectVisibility(menu);
       }

       if(menu.GetComponent<Renderer>().enabled == true)
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
       }
    }
}
