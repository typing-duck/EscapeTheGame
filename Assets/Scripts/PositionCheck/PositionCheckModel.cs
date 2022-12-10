using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionCheckModel : MonoBehaviour
{
    [HideInInspector] 
    public bool correctPosition;
    public GameObject target;

    void Start()
    {
     correctPosition = false;    
    }
}