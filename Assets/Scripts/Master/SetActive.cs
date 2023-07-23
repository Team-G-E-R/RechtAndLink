using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetActive : MonoBehaviour
{
    [SerializeField] GameObject objectToActive;
    public void Set()
    {
        objectToActive.SetActive(true);
    }
}
