using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class BasedDialogue : MonoBehaviour
{
    public TMP_Text DialogueText;
    public TMP_Text RightCharacterName;
    public TMP_Text LeftCharacterName;
    public Image LeftCharacterImage;
    public Image RightCharacterImage;
    public bool dialogueIsPlaying = false;

    private IEnumerator coroutine;
    /* public float DialogueTimerValue; */
    public Queue<string> Sentence;
    /*  public Queue<string> Name; */
    public Queue<bool> RpSpeak;
    public float WaitForMS = 0.05f;
    /*  public Queue<Sprite> CharacterSprite; */
    /* public Queue<float> DialogueTime; */

    public Animator animator;
    public Animator RightAnim;
    public Animator LeftAnim;

    private void Start()
    {
        Sentence = new Queue<string>();
        /*  Name= new Queue<string>();
         CharacterSprite= new Queue<Sprite>(); */
        RpSpeak = new Queue<bool>();
        /* DialogueTime= new Queue<float>(); */
    }

    public void StartDialogue(DialogueWindow dialogue)
    {

        dialogueIsPlaying = true;
        RightCharacterName.text = dialogue.rightCharacterName;
        LeftCharacterName.text = dialogue.leftCharacterName;
        LeftCharacterImage.sprite = dialogue.leftCharacterImage;
        RightCharacterImage.sprite = dialogue.rightCharacterImage;

        animator.SetBool("isOpen", true);

        Sentence.Clear();
        /* CharacterSprite.Clear();
        Name.Clear(); */
        RpSpeak.Clear();

        /* foreach (Sprite characterSprite  in dialogue.characterSprite)
        {
            CharacterSprite.Enqueue(characterSprite);
        }
        foreach (string name in dialogue.name)
        {
            Name.Enqueue(name);
        } */
        /* foreach (float dialogueTime in dialogue.dialogueTime)
        {
            DialogueTime.Enqueue(dialogueTime);
        } */
        foreach (string sentenses in dialogue.sentenses)
        {
            Sentence.Enqueue(sentenses);
        }
        foreach (bool rightPersonSpeaking in dialogue.rightPersonSpeaking)
        {
            RpSpeak.Enqueue(rightPersonSpeaking);
        }

        DisplayNextLine();

    }


    private void DisplayNextLine()
    {
        if (Sentence.Count == 0)
        {
            EndDialogue();
            return;
        }
        string sentense = Sentence.Dequeue();
        /* string name = Name.Dequeue();
        Sprite characterSprite = CharacterSprite.Dequeue(); */
        bool rightPersonSpeaking = RpSpeak.Dequeue();
        /* float dialogueTime = DialogueTime.Dequeue(); */
        coroutine = (TypeLines(sentense,/*  name, characterSprite, */ rightPersonSpeaking
        /* , dialogueTime */ ));
        StartCoroutine(coroutine);
        /* /* (TypeLines(sentense,/*  name, characterSprite, */ /* rightPersonSpeaking */
        /* , dialogueTime)); */
    }

    IEnumerator TypeLines(string sentense, /* string name,  Sprite characterSprite, */ bool rightPersonSpeaking
    /* , float dialogueTime */)
    {

        if (rightPersonSpeaking)
        {
            RightAnim.SetBool("isHightlited", true);
            LeftAnim.SetBool("isHightlited", false);
        }
        else
        {
            RightAnim.SetBool("isHightlited", false);
            LeftAnim.SetBool("isHightlited", true);
        }
        DialogueText.text = "";
        /* CharacterName.text=name;
        CharacterImage.sprite=characterSprite; */
        /* DialogueTimerValue=dialogueTime; */
        foreach (char letter in sentense.ToCharArray())
        {

            /* if (LineCol>CurCol)
            {
                Debug.Log(LineCol);
                Debug.Log(CurCol);
                break;
            } */
            DialogueText.text += letter;
            yield return new WaitForSeconds(WaitForMS);
            /* yield return null; */

        }

        /* StartCoroutine(NextDialogueStage()); */
    }
    /* IEnumerator NextDialogueStage()
    {
       yield return new WaitForSeconds(DialogueTimerValue);
       DisplayNextLine();
    } */

    private void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space)) && (dialogueIsPlaying == true))
        {

            StopCoroutine(coroutine);

            DisplayNextLine();
        }
    }
    private void EndDialogue()
    {
        dialogueIsPlaying = false;
        animator.SetBool("isOpen", false);

    }

}
