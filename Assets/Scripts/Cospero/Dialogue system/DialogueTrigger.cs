using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger : MonoBehaviour
{
    public DialogueWindow dialogue;
    private bool DiaPlaying;
   
    public void ActivateDialogue()
    {   
        DiaPlaying=FindObjectOfType<DialogueManagerCutscene>().dialogueIsPlaying;
        if(DiaPlaying==false)
        {
            FindObjectOfType<DialogueManagerCutscene>().StartDialogue(dialogue);
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
