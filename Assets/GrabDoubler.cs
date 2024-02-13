using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabDoubler : MonoBehaviour
{
    public List<CustomGrab> hands;
    private bool doubleGrabbing = false;

    // Start is called before the first frame update
    void Start()
    {
        Material material = GetComponent<MeshRenderer>().material;
        GetComponent<HandButton>().buttonPressed += () =>
        {
            doubleGrabbing = !doubleGrabbing;
            material.color = doubleGrabbing ? Color.green : Color.red;
            foreach (CustomGrab hand in hands)
                hand.doubleGrab = doubleGrabbing;
        };
    }
}
