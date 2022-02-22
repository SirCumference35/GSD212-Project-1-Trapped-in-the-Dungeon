using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public PlayerMovement movementjoystick;
    public float playerSpeed = 5f;
    private Rigidbody2D rb;




    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (movementjoystick.joyStickVec.y != 0)
        {
            rb.velocity = new Vector2(movementjoystick.joyStickVec.x * playerSpeed, movementjoystick.joyStickVec.y * playerSpeed);
        }
        else
        {
            rb.velocity = Vector2.zero;
        }
    }
}
