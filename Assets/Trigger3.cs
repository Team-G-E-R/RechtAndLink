using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTrigger3 : MonoBehaviour
{
    [SerializeField] GameObject player;
    public DialogueWindow dialogue;
    public bool needToOffControl;
    private bool DiaPlaying;

    public void ActivateDialogue()
    {
        if (needToOffControl == true)
        {
            player.GetComponent<movecontr>().enabled = false;
            player.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            DiaPlaying = FindObjectOfType<Dialogues3>().dialogueIsPlaying;
            if (DiaPlaying == false)
            {
                FindObjectOfType<Dialogues3>().StartDialogue(dialogue);
            }
        }
        else if (needToOffControl == false)
        {
            DiaPlaying = FindObjectOfType<Dialogues3>().dialogueIsPlaying;
            if (DiaPlaying == false)
            {
                FindObjectOfType<Dialogues3>().StartDialogue(dialogue);
            }
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
