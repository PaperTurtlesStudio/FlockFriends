using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceMovement : MonoBehaviour
{
    public float speed = 5f;
    Rigidbody2D rb;
    public Vector2 movement = new Vector2(0, -1);


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + (movement * speed * Time.fixedDeltaTime));
    }
}
