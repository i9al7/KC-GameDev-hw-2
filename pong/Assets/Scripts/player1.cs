using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player1 : MonoBehaviour
{
    Rigidbody2D RB;
    public float speed;
    private float movement;

    // Start is called before the first frame update
    void Start()
    {
        RB = this.GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Movement();
    }

    void Movement()
    {
        movement = Input.GetAxis("Vertical");
        RB.velocity = new Vector2(0f, movement * speed);
    }

}
