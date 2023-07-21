using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Learning1 : MonoBehaviour
{
    public TMP_Text UiText;
    [TextArea(10, 10)]
    public string text;
    public float timeBetweenCharSpawn;
    public int delayBeforeStart;
    public float timeAfterAllTextToSpawn;
    private bool leadingCharBeforeDelay = false;
    private string leadingChar = "";
    public GameObject whatToSpawn;
    void Start()
    {
        UiText.text = text;
        StartCoroutine(onObject());
    }

    private IEnumerator onObject()
    {
        /*if (leadingCharBeforeDelay)
            UiText.text = leadingChar;
        else
            UiText.text = "";*/

        //ÅÁÀÀÀÀÒÜ ÏÐÈÊÈÍÜÒÅ ÝÒÎ ÎÄÍÎ È ÒÎ ÆÅ ÑÂÅÐÕÓ È ÑÍÈÇÓ ÕÀÕÀÕÀ
        UiText.text = leadingCharBeforeDelay ? leadingChar : "";


        yield return new WaitForSeconds(delayBeforeStart);

        foreach (char a in text)
        {
            if (UiText.text.Length > 0)
            {
                UiText.text = UiText.text.Substring(0, UiText.text.Length - leadingChar.Length);
            }
            UiText.text += a;
            UiText.text += leadingChar;
            yield return new WaitForSeconds(timeBetweenCharSpawn);
        }
        
        yield return new WaitForSeconds(timeAfterAllTextToSpawn);
        whatToSpawn.SetActive(true);
    }
}
