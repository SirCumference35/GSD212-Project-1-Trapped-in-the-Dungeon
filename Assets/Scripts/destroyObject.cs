using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyObject : MonoBehaviour
{
    public GameObject Door;


    public void OnTriggerEnter2D(Collider2D target)
    {
        if (target.tag == "Bomb")
        {
            Destroy(this.gameObject);
        }
    }
}
