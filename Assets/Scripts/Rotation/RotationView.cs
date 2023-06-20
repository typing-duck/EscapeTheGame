using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationView : BaseView
{
    public void Rotate90(GameObject obj, int currentRotationsTooFar)
    {
      obj.transform.Rotate(0f,0f,-90f);
    }
}
