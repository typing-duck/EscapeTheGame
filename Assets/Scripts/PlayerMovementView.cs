using UnityEngine;

public class PlayerMovementView : MonoBehaviour
{
    public void ChangeAnimator(Animator animator, string name, float value)
    {
      animator.SetFloat(name, value);
    }
}
