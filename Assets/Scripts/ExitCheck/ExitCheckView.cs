using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCheckView : BaseView
{
  public Sprite doorOpen;
  public Sprite doorClose;

  void Start()
  {
    doorOpen = Resources.Load<Sprite>("door_open");
    doorClose = Resources.Load<Sprite>("door_close");
  }

  public void LoadNextLevel()
  {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
  }
}
