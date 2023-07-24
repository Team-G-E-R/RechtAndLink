using System;
using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadeInOut : MonoBehaviour
{
    [SerializeField] float duration;
    [SerializeField] Image imageForFade;
    private float currentTime;
    public void FadeIn()
    {
        StartCoroutine(FadeInCrt());
    }

    public void FadeOut()
    {

        StartCoroutine(FadeOutCrt());
    }

    private IEnumerator FadeInCrt()
    {
        while (currentTime < duration)
        {
            float alpha = Mathf.Lerp(0f, 1f, currentTime / duration); //меняешь местами 0 и 1 и оно фейдится
            imageForFade.color = new Color(imageForFade.color.r, imageForFade.color.g, imageForFade.color.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }
        currentTime = 0;
        yield break;
    }

    private IEnumerator FadeOutCrt()
    {
        while (currentTime < duration)
        {
            float alpha = Mathf.Lerp(1f, 0f, currentTime / duration); //меняешь местами 0 и 1 и оно не фейдится
            imageForFade.color = new Color(imageForFade.color.r, imageForFade.color.g, imageForFade.color.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }
        currentTime = 0;
        yield break;
    }
}
