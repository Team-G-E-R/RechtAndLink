using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public UnityEvent InteractAction;
    [SerializeField] bool needToActivateSomething;
    [SerializeField] GameObject whatToActivate;

    // Update is called once per frame
    public void Interact()
    {
        if (needToActivateSomething == true)
        {
            InteractAction.Invoke();
            whatToActivate.SetActive(true);
        }
        else if (needToActivateSomething == false)
        {
            InteractAction.Invoke();
        }
    }
}
