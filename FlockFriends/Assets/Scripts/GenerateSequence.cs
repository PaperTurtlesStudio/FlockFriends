using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenerateSequence : MonoBehaviour
{
    public GameObject gameManager;
    public SequenceManager sqm;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        sqm = gameManager.GetComponent<SequenceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTrEnter2D(Collision2D collision)
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "Player")
        {
            GameObject sequenceHolder = sqm.requestSequence();
            sequenceHolder.GetComponent<Rigidbody2D>().position = new Vector2(-9.989263f, 50f);
        }
    }
}
