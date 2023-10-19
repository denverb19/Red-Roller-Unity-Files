using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropScript : MonoBehaviour
{
    int secondsElapsed = 0;
    [SerializeField] float dropDelay = 3.0f;
    MeshRenderer thisRenderer;
    Rigidbody thisRigidbody;
    void Start()
    {
        thisRenderer = GetComponent<MeshRenderer>();
        thisRigidbody = GetComponent<Rigidbody>();
        thisRenderer.enabled = false;
        thisRigidbody.useGravity = false;
    }
    void Update()
    {
        /*
        if(Time.time >= (secondsElapsed + 1.0f))
        {
            Debug.Log("Elapsed Time: " + Time.time + "!");
            secondsElapsed += 1;
        }
        */
        if (Time.time >= dropDelay)
        {
            thisRenderer.enabled = true;
            thisRigidbody.useGravity = true;
        }
    }
}
