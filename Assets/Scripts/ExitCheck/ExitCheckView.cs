using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCheckView : BaseView
{
  public Sprite doorOpen;
  public Sprite doorClose;

  public void LoadNextLevel()
  {
   if(SceneManager.GetActiveScene().buildIndex < 3)
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
  }
}
