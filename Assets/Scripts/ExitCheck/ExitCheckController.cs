using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExitCheckController : MonoBehaviour
{
  private ExitCheckModel exitCheckModel;
  private ExitCheckView exitCheckView;

  void Start()
  {
   exitCheckModel = GetComponent<ExitCheckModel>();
   exitCheckView = GetComponent<ExitCheckView>();
  }

  void Update()
  {
   exitCheckView.ChangeSprite(GetComponent<SpriteRenderer>(), exitCheckModel.doorClose);
   if(exitCheckModel.openExit)
   {
	  exitCheckView.ChangeSprite(GetComponent<SpriteRenderer>(), exitCheckModel.doorOpen);
   }
   exitCheckModel.openExit = true;
   foreach(IsEnd obj in exitCheckModel.allObjects)
   {
    if(obj.Done() == false)
    {
      exitCheckModel.openExit = false;
      break;
    }
   }
  }

  private void OnTriggerEnter2D(Collider2D collision)
  {
    if(exitCheckModel.openExit == true && collision.tag == "Player")
    {
      exitCheckView.LoadNextLevel();
    }
  }
}
