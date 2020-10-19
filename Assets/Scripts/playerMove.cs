using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    SpriteRenderer sR;
    public Sprite standSprite;
    public Sprite jumpSprite;
    public Sprite fallingSprite;
    public Sprite attackSprite;
    public Sprite midairSprite;
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sR = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 velocity = rb.velocity;
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
            velocity.y = 6;
        }
        rb.velocity = velocity;
        //Makes the player jump. The more it's held, the higher the jump.

        if (velocity.y > 0.2f)
        {
            sR.sprite = jumpSprite;
        }
        else
        {
            sR.sprite = standSprite;
        }
        //Initiates the jumping animation depending on the player's velocity
        if (Input.GetKey("z"))
        {
            sR.sprite = attackSprite;
        }
        //Initiates the attack animation when Z is pressed

        if (velocity.y < -0.5f)
        {
            sR.sprite = fallingSprite;
        }
        //Initiates the falling animation depending on the player's velocity
    }
}