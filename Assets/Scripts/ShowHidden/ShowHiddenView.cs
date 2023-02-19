using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenView : MonoBehaviour
{
    public void MoveToLayer(ShowHiddenModel model, int layer)
    {
        SpriteRenderer spriteRenderer = model.gameObject.GetComponent<SpriteRenderer>();
        spriteRenderer.sortingOrder = layer;
    }
}
