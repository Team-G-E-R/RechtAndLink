using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class DialogueWindow 
{
    /* public string[] name;
    public float[] dialogueTime; 
    public Sprite[] characterSprite; */

    [TextArea(3,10)]
    public string[] sentenses;

    public bool[] rightPersonSpeaking;
    public string rightCharacterName;
    public string leftCharacterName;
    public Sprite leftCharacterImage;
    public Sprite rightCharacterImage;

   
}
