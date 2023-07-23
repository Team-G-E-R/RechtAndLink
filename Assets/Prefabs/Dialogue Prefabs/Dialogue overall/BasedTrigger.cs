using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasedTrigger : MonoBehaviour
{
    [SerializeField] GameObject player;
    public DialogueWindow dialogue;
    public bool needToOffControl;
    private bool DiaPlaying;

    public void ActivateDialogue()
    {
        if (needToOffControl == true)
        {
            player.GetComponent<Animator>().enabled = false;
            player.GetComponent<movecontr>().enabled = false;
            player.transform.GetComponent<Rigidbody2D>().bodyType = RigidbodyType2D.Static;
            DiaPlaying = FindObjectOfType<BasedDialogue>().dialogueIsPlaying;
            if (DiaPlaying == false)
            {
                FindObjectOfType<BasedDialogue>().StartDialogue(dialogue);
            }
        }
        else if(needToOffControl == false)
        {
            DiaPlaying = FindObjectOfType<BasedDialogue>().dialogueIsPlaying;
            if (DiaPlaying == false)
            {
                FindObjectOfType<BasedDialogue>().StartDialogue(dialogue);
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

