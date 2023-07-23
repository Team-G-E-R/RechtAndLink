using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerNEW : MonoBehaviour
{
    public DialogueWindow dialogue;
    private bool DiaPlaying;

    public void ActivateDialogue()
    {
        DiaPlaying = FindObjectOfType<DialogueManagerCutsceneNEW>().dialogueIsPlaying;
        if (DiaPlaying == false)
        {
            FindObjectOfType<DialogueManagerCutsceneNEW>().StartDialogue(dialogue);
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
