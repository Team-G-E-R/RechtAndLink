using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour
{
    public TMP_Text DialogueText;
    public TMP_Text CharacterName;
    public Image CharacterImage;

    public float DialogueTimerValue;
    public Queue<string> Sentence;
    public Queue<string> Name;
    public Queue<Sprite> CharacterSprite;
    public Queue<float> DialogueTime;

    public Animator animator;
    private void Start()
    {
        Sentence= new Queue<string>();  
        Name= new Queue<string>();
        CharacterSprite= new Queue<Sprite>();
        DialogueTime= new Queue<float>();
    }

    public void StartDialogue(DialogueWindow  dialogue)
   {
    animator.SetBool("isOpen", true);

    Sentence.Clear();
    CharacterSprite.Clear();
    Name.Clear();

    foreach (Sprite characterSprite  in dialogue.characterSprite)
    {
        CharacterSprite.Enqueue(characterSprite);
    }
    foreach (string name in dialogue.name)
    {
        Name.Enqueue(name);
    }
    foreach (float dialogueTime in dialogue.dialogueTime)
    {
        DialogueTime.Enqueue(dialogueTime);
    }
    foreach (string sentenses in dialogue.sentenses)
    {
        Sentence.Enqueue(sentenses);
    }

    DisplayNextLine();

   }


    private void DisplayNextLine()
    {
        if (Sentence.Count==0)
        {
            EndDialogue();
            
        }
        string sentense = Sentence.Dequeue();
        string name = Name.Dequeue();
        Sprite characterSprite = CharacterSprite.Dequeue();
        float dialogueTime = DialogueTime.Dequeue();
        StartCoroutine(TypeLines(sentense, name, characterSprite, dialogueTime ));
    }

    IEnumerator TypeLines(string sentense, string name,  Sprite characterSprite, float dialogueTime)
    {
        DialogueText.text="";
        CharacterName.text=name;
        CharacterImage.sprite=characterSprite;
        DialogueTimerValue=dialogueTime;
        foreach (char letter in sentense.ToCharArray())
        {
            DialogueText.text +=letter;
            yield return null;
        }
        StartCoroutine(NextDialogueStage());
    }
    IEnumerator NextDialogueStage()
    {
       yield return new WaitForSeconds(DialogueTimerValue);
       DisplayNextLine();
    }

   private void EndDialogue()
   {
    animator.SetBool("isOpen", false);
   }

}
