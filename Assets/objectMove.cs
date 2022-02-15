using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectMove : MonoBehaviour
{

    public GameObject wall;
    public float rotateNumber = 90f;

    public void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Player")
        {
            transform.Rotate(0, 0, rotateNumber);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
