using UnityEngine;
using System.Collections;

public class InitScripts : MonoBehaviour 
{
    void Start ()
    {
      GameObject controllers = GameObject.Find("Controllers");
      GameObject views = GameObject.Find("Views");

       if(GameObject.FindObjectOfType<BulbModel>() != null)
       {
         controllers.AddComponent<BulbController>();
         views.AddComponent<BulbView>();
       }
       if(GameObject.FindObjectOfType<ButtonModel>() != null)
       {
        controllers.AddComponent<ButtonController>();
       }
       if(GameObject.FindObjectOfType<ExitCheckModel>() != null)
       {
         controllers.AddComponent<ExitCheckController>();
         views.AddComponent<ExitCheckView>();
       }
       if(GameObject.FindObjectOfType<LetterModel>() != null)
       {
         controllers.AddComponent<LetterController>();
         views.AddComponent<LetterView>();
       }
       if(GameObject.FindObjectOfType<PlayerMovementModel>() != null)
       {
         controllers.AddComponent<PlayerMovementController>();
         views.AddComponent<PlayerMovementView>();
       }
       if(GameObject.FindObjectOfType<PositionCheckModel>() != null)
       {
         controllers.AddComponent<PositionCheckController>();
       }
       if(GameObject.FindObjectOfType<ShowHiddenModel>() != null)
       {
         controllers.AddComponent<ShowHiddenController>();
         views.AddComponent<ShowHiddenView>();
       }
       if(GameObject.FindObjectOfType<SwitchModel>() != null)
       {
         controllers.AddComponent<SwitchController>();
       }
       if(GameObject.FindObjectOfType<VolumeModel>() != null)
       {
         controllers.AddComponent<VolumeController>();
         views.AddComponent<VolumeView>();
       }
    }
}