using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCheckView : MonoBehaviour
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
     door.GetComponent<SpriteRenderer>().sprite = doorOpen;
    }
    else
    {
      door.GetComponent<SpriteRenderer>().sprite = doorClose;
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
