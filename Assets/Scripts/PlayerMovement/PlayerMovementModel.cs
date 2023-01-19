using UnityEngine;
using System.Collections.Generic;

public class PlayerMovementModel : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    public List<GameObject> blackoutSwitchers = new List<GameObject>();

    void Start()
    {
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
