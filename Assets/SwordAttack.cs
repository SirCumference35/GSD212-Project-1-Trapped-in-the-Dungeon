using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordAttack : MonoBehaviour
{

    public GameObject Sword;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void buttonClicked() 
    {
        if (Sword.activeInHierarchy == true)
            Sword.SetActive(false);
        else
            Sword.SetActive(true);
    
    }

   



}
