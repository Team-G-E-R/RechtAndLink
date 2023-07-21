using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueWindow dialogue;

    public void ActivateDialogue()
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
