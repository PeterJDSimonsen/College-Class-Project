using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyMove : MonoBehaviour
{
    int timer;
    Rigidbody2D rb;
    void Start()
    {
        timer = 0;
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        timer++;
        if (timer == 600)
        {
            timer = 0;
            rb.velocity = new Vector2(5, 0);
            Debug.Log(timer);
        }
        if (timer == 300)
        {
            rb.velocity = new Vector2(-5, 0);
        }
    }
}