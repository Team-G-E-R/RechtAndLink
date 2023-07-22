using System;
using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class FadingScript : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI textDisplay;
    [SerializeField] float duration;
    [SerializeField] float timeBetweenScenes;
    [SerializeField] Image imageForFade;
    [SerializeField] float fadeImageDuration;
    [SerializeField] int sceneToLoad;
    private float currentTime;
    public void Start()
    {
        StartCoroutine(FadeOut());
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            StartCoroutine(SceneChange());
        }
    }

    public IEnumerator SceneChange()
    {
        //сюда фейд картинки 21 год спустя
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

    private IEnumerator FadeOut()
    {
        while (currentTime < duration)
        {
            float alpha = Mathf.Lerp(0f, 1f, currentTime / duration); //меняешь местами 0 и 1 и оно фейдится
            textDisplay.color = new Color(textDisplay.color.r, textDisplay.color.g, textDisplay.color.b, alpha);
            currentTime += Time.deltaTime;
            yield return null;
        }
        yield break;
    }
}
