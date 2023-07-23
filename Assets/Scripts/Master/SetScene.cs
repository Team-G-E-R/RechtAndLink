using System;
using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SetScene : MonoBehaviour
{
    [SerializeField] float timeBetweenScenes;
    [SerializeField] Image imageForFade;
    [SerializeField] float fadeImageDuration;
    [SerializeField] int sceneToLoad;
    public void ChangeScene()
    {
        StartCoroutine(FadeAndChange());
    }
    IEnumerator FadeAndChange()
    {
        Color color = imageForFade.color;

        while (color.a < 1f)
        {
            color.a += fadeImageDuration * Time.deltaTime;
            imageForFade.color = color;
            yield return null;
        }
        yield return new WaitForSeconds(timeBetweenScenes);
        SceneManager.LoadScene(sceneToLoad);
    }
}
