using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{
    private MenuModel model;
    private MenuView view;

    public GameObject border;
    public GameObject optionsTable;
    private int borderStage = 1;

    void Start()
    {
     model = GameObject.FindObjectOfType<MenuModel>();
     view = GameObject.FindObjectOfType<MenuView>();

     border = GameObject.Find("SelectBorder");
     optionsTable = GameObject.Find("OptionsTable");
    }

    void Update()
    {
       if(Input.GetKeyDown(KeyCode.DownArrow) && borderStage < 3)
       {
         borderStage = borderStage + 1;
         view.MoveBorder(border, "down");
       } 
       if(Input.GetKeyDown(KeyCode.UpArrow) && borderStage > 1)
       {
         borderStage = borderStage - 1;
         view.MoveBorder(border, "up");
       }
       if(Input.GetKeyDown(KeyCode.Return))
       {
         if(borderStage == 1)
         {
           SceneManager.LoadScene(1);
         }
         else if(borderStage == 2)
         {
           view.ShowTable(optionsTable, true);
         }
         else if(borderStage == 3)
         {
           Application.Quit();
         }
       }
       if(Input.GetKeyDown(KeyCode.Escape))
       {
         view.ShowTable(optionsTable, false);
       }
    }
}
