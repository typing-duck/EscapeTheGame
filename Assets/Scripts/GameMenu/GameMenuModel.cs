using System.Collections;
using System.Collections.Generic;
using static System.Linq.Enumerable;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMenuModel : MonoBehaviour
{
  public int maxPosition;
  public int framePosition = 0;
  private string[] menuOptions = {"Replay", "MainMenu"};

  void Start()
  {
    maxPosition = menuOptions.Count() - 1;
  }

  public string GetMenuOption()
  {
    return menuOptions[framePosition];
  }
}