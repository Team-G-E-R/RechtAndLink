using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Activator : MonoBehaviour
{
   public bool IsInRange;
   public KeyCode InteractKey;
   /* public UnityEvent InteractAction; */
   private GameObject InteractItem;
   private void Start() {
    
   }

   private void Update() 
   {    
        if(IsInRange)
        {
            if(Input.GetKeyDown(InteractKey))
            {   if(InteractItem.GetComponent<Interactable>() )
                {
                    
                    InteractItem.GetComponent<Interactable>().Interact();
                    /* InteractAction.Invoke(); */
                }
                
            }
        }
   }

   private void OnTriggerEnter2D(Collider2D other)
   {
        if ((other.tag == "Interactable"))
        {
            
            IsInRange=true;
            InteractItem=other.gameObject;
            
        }
   }

   private void OnTriggerExit2D(Collider2D other) 
   {
        if ((other.tag == "Interactable"))
        {
            IsInRange=false;
            

            
        }
   }
}
