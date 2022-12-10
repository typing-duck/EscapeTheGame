using UnityEngine;

public class PlayerMovementModel : MonoBehaviour
{
    public float MoveSpeed = 1f;
    public Rigidbody2D rb;
    public Animator animator;
    public Vector2 movement;
    public GameObject[] blackoutSwitchers;

    void Start()
    {
      blackoutSwitchers = GameObject.FindGameObjectsWithTag("BlackoutSwitcher");
    }
}
