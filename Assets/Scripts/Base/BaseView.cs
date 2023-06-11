using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.Rendering.Universal;

public class BaseView : MonoBehaviour
{
  public Color32 yellow = new Color32(255,190,0,255);
  public Color32 white = new Color32(255,255,255,255);
  public Color32 black = new Color32(0,0,0,255);
  public Color32 grey = new Color32(111,111,111,255);
  public Color32 pink = new Color32(255,170,255,255);
  public Color32 blended_purple = new Color32(125, 65, 140, 255);

  public void ChangeSprite(GameObject obj, Sprite newSprite)
  {
    obj.GetComponent<SpriteRenderer>().sprite = newSprite;
  }

  public void ChangeSpriteColor(GameObject obj, Color32 new_color)
  {
    obj.GetComponent<SpriteRenderer>().color = new_color;
  }

  public void ShowObject(GameObject obj)
  {
    obj.GetComponent<Renderer>().enabled = true;
    for(int i=0; i < obj.transform.childCount; i++)
    {
      GameObject child = obj.transform.GetChild(i).gameObject;
      child.GetComponent<Renderer>().enabled = true;
    }
  }

  public void HideObject(GameObject obj)
  {
    obj.GetComponent<Renderer>().enabled = false;
    for(int i=0; i < obj.transform.childCount; i++)
    {
      GameObject child = obj.transform.GetChild(i).gameObject;
      child.GetComponent<Renderer>().enabled = false;
    }
  }

  public void ChangeObjectVisibility(GameObject obj)
  {
    obj.GetComponent<Renderer>().enabled = !obj.GetComponent<Renderer>().enabled;
    for(int i=0; i < obj.transform.childCount; i++)
    {
      GameObject child = obj.transform.GetChild(i).gameObject;
      child.GetComponent<Renderer>().enabled = !child.GetComponent<Renderer>().enabled;
    }
  }
}
