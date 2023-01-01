using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowHiddenModel : MonoBehaviour
{
    public GameObject switcherOn1;
    public GameObject switcherOn2;
    public SpriteRenderer spriteRenderer;
    public int layerToMove = 2;

    private ShowHiddenController controller;
    private ShowHiddenView view;

    void Start()
    {
      spriteRenderer = GetComponent<SpriteRenderer>();
      controller = gameObject.AddComponent<ShowHiddenController>();
      view = gameObject.AddComponent<ShowHiddenView>();
    }

}
