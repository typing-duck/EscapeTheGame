using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheck : MonoBehaviour
{
  public bool openExit;
  public Sprite doorOpen;
  public Sprite doorClose;
  private IsEnd[] allObjects;

  void Start()
  {
   openExit = false;
   allObjects = GameObject.FindObjectsOfType<IsEnd>();
  }

  void Update()
  {
   if(openExit)
   {
	  GetComponent<SpriteRenderer>().sprite = doorOpen;
   }
   else
   {
    GetComponent<SpriteRenderer>().sprite = doorClose;
   }
   openExit = true;
   foreach(IsEnd obj in allObjects)
   {
    if(obj.Done() == false)
    {
      openExit = false;
      break;
    }
   }
}
}
