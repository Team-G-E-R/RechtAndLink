using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class interactions : MonoBehaviour
{
    public List<GameObject> UsingObject;
    public TextMeshProUGUI textTmp;
    public string TextInteraction = "";
    private bool isTouching = false;
    
    private void OnCollisionEnter2D(Collision2D collistion)
    {
        isTouching = true;
    }
    private void OnCollisionExit2D(Collision2D collistion)
    {
        isTouching = false;
    }
    private void Update()
    {
        if (isTouching)
        {
            textTmp.SetText(TextInteraction);

        }
        else
        {
            textTmp.SetText("");
        }
    }
}