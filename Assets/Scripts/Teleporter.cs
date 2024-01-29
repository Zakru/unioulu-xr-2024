using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Teleporter : MonoBehaviour
{
    public InputActionReference action;
    public Transform insidePos;
    public Transform outsidePos;

    private bool inside = true;

    // Start is called before the first frame update
    void Start()
    {
        action.action.Enable();
        action.action.performed += (ctx) =>
        {
            inside = !inside;
            transform.position = inside ? insidePos.position : outsidePos.position;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
