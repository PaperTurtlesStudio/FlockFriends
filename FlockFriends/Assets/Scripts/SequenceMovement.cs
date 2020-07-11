using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceMovement : MonoBehaviour
{
    public float speed = 5f;
    public Rigidbody2D rb;
    public Vector2 movement = new Vector2(0, -1);

    // Start is called before the first frame update
    void Start()
    { 
        
    } 
  
    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + (movement * speed * Time.fixedDeltaTime));
    }
}
