using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCheckView : BaseView
{
  private GameObject door;
  public Sprite doorOpen;
  public Sprite doorClose;

  void Start()
  {
    door = GameObject.FindGameObjectWithTag("Door");
  }

  public void SpriteDoorOpen(bool state)
  {
    if(state == true)
    {
     ChangeSprite(door, doorOpen);
    }
    else
    {
     ChangeSprite(door, doorClose);
    }
  }

  public void LoadNextLevel()
  {
   if(SceneManager.GetActiveScene().buildIndex < 2)
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
  }
}
