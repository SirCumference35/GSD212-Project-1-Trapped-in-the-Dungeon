using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordThrow : MonoBehaviour
{

    public Transform Firepoint;
    public GameObject prefab;

    public float SwordSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void shoot() 
    {
        GameObject bullet = Instantiate(prefab, Firepoint.position, Firepoint.rotation);
        Rigidbody2D rb = bullet.GetComponent<Rigidbody2D>();
        rb.AddForce(Firepoint.up * SwordSpeed, ForceMode2D.Impulse);

    }
}
