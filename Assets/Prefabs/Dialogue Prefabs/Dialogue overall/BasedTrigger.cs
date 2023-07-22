using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasedTrigger : MonoBehaviour
{
    public DialogueWindow dialogue;
    private bool DiaPlaying;

    public void ActivateDialogue()
    {
        DiaPlaying = FindObjectOfType<BasedDialogue>().dialogueIsPlaying;
        if (DiaPlaying == false)
        {
            FindObjectOfType<BasedDialogue>().StartDialogue(dialogue);
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

