using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyLittleBird : MonoBehaviour
{
    public float velocity = 1;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)){
            // Jump
            rb.velocity = Vector2.up * velocity;
        }
    }
}
