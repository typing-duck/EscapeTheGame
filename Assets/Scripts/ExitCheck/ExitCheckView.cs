using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExitCheckView : MonoBehaviour
{
  public void ChangeSprite(SpriteRenderer spriteRenderer, Sprite newSprite)
  {
   spriteRenderer.sprite = newSprite;
  }

  public void LoadNextLevel()
  {
   if(SceneManager.GetActiveScene().buildIndex < 2)
   {
    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
   }
  }
}
