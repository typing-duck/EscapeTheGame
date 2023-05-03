using UnityEngine;
using System.Collections.Generic;

public class PlayerMovementModel : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    public List<GameObject> blackoutSwitchers = new List<GameObject>();
    public bool canMove;

    void Start()
    {
      canMove = true;
      
      GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
      foreach(GameObject obj in allObjects)
      {
       if(obj.tag.Contains("Blackout"))
       {
        blackoutSwitchers.Add(obj);
       }
      }
    }
}
