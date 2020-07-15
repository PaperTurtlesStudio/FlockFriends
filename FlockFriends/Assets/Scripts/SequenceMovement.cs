using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SequenceMovement : MonoBehaviour
{

    GameObject gameManager;
    SequenceManager sequenceManager;
    Rigidbody2D rb;
    public Vector2 movement = new Vector2(0, -1);


    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        gameManager = GameObject.Find("GameManager");
        sequenceManager = gameManager.GetComponent<SequenceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(rb.position + (movement * sequenceManager.SequenceSpeed * Time.fixedDeltaTime));
    }
}
