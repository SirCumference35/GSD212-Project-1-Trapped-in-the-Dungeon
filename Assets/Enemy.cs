using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{

    public GameObject enemy;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }



    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "Sword")
        {
            Debug.Log("why wont you work ;_;");
        }
    }


}
