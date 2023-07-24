using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Cutscenestart : MonoBehaviour
{
    [SerializeField] PlayableDirector director;

    public void OnCollisionEnter2D(Collision2D collision)
    {
        director.Play();
        Destroy(gameObject);
    }
}
