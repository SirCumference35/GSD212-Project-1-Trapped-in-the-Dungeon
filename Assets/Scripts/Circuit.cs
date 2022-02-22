using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Circuit : MonoBehaviour
{
    // The two different Unity events which will be used to destroy the door
    public UnityEvent RegisterCircuit;
    public UnityEvent DeregisterCircuit;

    // When the game starts, the object which is selected (the door in this case) will be registered.
    void Start()
    {
        RegisterCircuit.Invoke();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnDestroy()
    {
        // When the keys are collected, this event will be called and the door will be destroyed
        DeregisterCircuit.Invoke();
    }
}
