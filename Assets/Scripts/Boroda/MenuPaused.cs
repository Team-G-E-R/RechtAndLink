using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPaused : MonoBehaviour
{
    public GameObject menuPaused;
    [SerializeField] KeyCode KeyMenuPaused;
    bool isMenuPaused = false;
    private void Start()
    {
        menuPaused.SetActive(false);
    }

    void ActiveMenu()
    {
        if (input.GetKey(KeyMenuPaused))
        {
            isMenuPaused = !isMenuPaused;
        }

        if (isMenuPaused)
        {
            menuPaused.SetActive(true);
            crosshair.enabled = false;
            Cursor.lockState = CursorLockMode.None;
        }
        else
        {
            menuPaused.SetActive(false);
            crosshair.enabled = true;
            Cursor.lockState = CursorLockMode.Locked;

        }
    }
}

