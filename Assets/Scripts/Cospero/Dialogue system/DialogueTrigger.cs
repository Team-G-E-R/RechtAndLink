using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueWindow dialogue;
    private bool DiaPlaying;
   
    public void ActivateDialogue()
    {   
        DiaPlaying=FindObjectOfType<DialogueManager>().dialogueIsPlaying;
        if(DiaPlaying==false)
        {
            FindObjectOfType<DialogueManager>().StartDialogue(dialogue);
        }
          
    }

    
   /*  private void OnTriggerEnter2D(Collider2D other) 
        
    
    {
        
        if ((other.tag == "Player"))
        {
            ActivateDialogue();
            
        }
    } */
}
