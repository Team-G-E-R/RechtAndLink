using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueWindow dialogue;

    private void ActivateDialogue()
    {
        FindObjectOfType<DialogueManager>().StartDialogue(dialogue);  
    }

    
    private void OnTriggerEnter2D(Collider2D other) 
        
    
    {
        
        if ((other.tag == "Player"))
        {
            ActivateDialogue();
            
        }
    }
}
