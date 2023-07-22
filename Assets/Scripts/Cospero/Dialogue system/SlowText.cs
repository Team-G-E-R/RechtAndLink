using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SlowText : MonoBehaviour
{
    public Text textUI;

    private string text = "Заброшенный лес находится позади проклятой горы. Если ты хочешь отправится туда, то возьми с собой на помощь эту волшебную подушечку, как только захочешь поспать, просто поклади её рядом и поспи.";

    void Start()
    {
        StartCoroutine("showText", text);
    }

    IEnumerator showText(string text)
    {
        int i = 0;
        while (i <= text.Length)
        {
            textUI.text = text.Substring(0, i);
            i++;

            yield return new WaitForSeconds(0.05f);
        }
    }
}