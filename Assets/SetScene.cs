using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SetScene : MonoBehaviour
{
    [SerializeField] int SceneToLoad;
    public void SceneChange()
    {
        SceneManager.LoadScene(SceneToLoad);
    }
}
