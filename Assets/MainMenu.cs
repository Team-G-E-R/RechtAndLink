using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void LoadLevel()
    {
        SceneManager.LoadScene("Scenes/Master/1 scene intro");// � �������� ����� �������� �����, �� ������� ����� �������
    }

    public void ExitGame()
    {
        Application.Quit();
    }
} 