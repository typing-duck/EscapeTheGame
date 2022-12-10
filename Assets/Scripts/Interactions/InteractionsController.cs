using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InteractionsController : MonoBehaviour
{
    private InteractionsModel interactionsModel;

    void Start()
    {
     interactionsModel = GetComponent<InteractionsModel>();
    } 

    void Update()
    {
        if(interactionsModel.isInRange)
        {
          if(Input.GetKeyDown(interactionsModel.interactKey))
	          {
	           interactionsModel.interactAction.Invoke();
	          }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("Player"))
      {
        interactionsModel.isInRange = true;
	      Debug.Log("Player is in range");
      }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
      if(collision.gameObject.CompareTag("Player"))
      {
        interactionsModel.isInRange = false;
	      Debug.Log("Player is not in range");
      }
    }

}
