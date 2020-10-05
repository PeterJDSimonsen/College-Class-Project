using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float xSpeed;
        if (Input.GetKey("d"))
        {
            xSpeed = 5.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }
        //Makes the player move right when D is pressed.

        if (Input.GetKey("a"))
        {
            xSpeed = -5.0f;
            transform.position += new Vector3(xSpeed * Time.deltaTime, 0, 0);
        }
        //Moves the player left when A is pressed.

        if (Input.GetKey("w"))
        {
            rb.velocity = new Vector3(0, 5, 0);
        }
        //Makes the player jump. The more it's held, the higher the jump.
    }
}