using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandButton : MonoBehaviour
{
    public delegate void ButtonHandler();
    public event ButtonHandler buttonPressed;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);
        if (other.CompareTag("Hand"))
        {
            buttonPressed.Invoke();
        }
    }
}
