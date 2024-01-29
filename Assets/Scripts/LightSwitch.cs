using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class LightSwitch : MonoBehaviour
{
    public InputActionReference action;
    public Color otherColor;

    private Light light;

    // Start is called before the first frame update
    void Start()
    {
        light = GetComponent<Light>();

        action.action.Enable();
        action.action.performed += (ctx) => {
            Color oldColor = light.color;
            light.color = otherColor;
            otherColor = oldColor;
        };
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
