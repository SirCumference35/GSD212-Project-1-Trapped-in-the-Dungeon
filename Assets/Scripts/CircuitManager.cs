using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Should be placed on the object which is going to be destroyed (In this case, the door)
public class CircuitManger : MonoBehaviour
{
    // Sets the amount of active objects to however many have the circuit script attached
    public int ActiveCircuits = 0;

    void Update()
    {
        // if all gems are collected, then the object is destroyed
        if (ActiveCircuits <= 0)
        {
            Destroy(this.gameObject);
        }
    }


    public void RegisterCircuit()
    {
        ActiveCircuits++;
    }

    public void DeregisterCircuit()
    {
        ActiveCircuits--;
    }
}
