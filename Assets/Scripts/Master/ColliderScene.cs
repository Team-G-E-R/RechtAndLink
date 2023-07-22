using System;
using System.Collections;
using System.Diagnostics;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class ColliderScene : MonoBehaviour
{
    [SerializeField] float timeBetweenScenes;
    [SerializeField] Image imageForFade;
    [SerializeField] float fadeImageDuration;
    [SerializeField] int sceneToLoad;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        StartCoroutine(SceneChange());
    }
    IEnumerator SceneChange()
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
