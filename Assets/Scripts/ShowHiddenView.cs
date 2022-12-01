using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenView : MonoBehaviour
{
    public void MoveToLayer(SpriteRenderer spriteRenderer, int layer)
    {
        spriteRenderer.sortingOrder = layer;
    }

}
