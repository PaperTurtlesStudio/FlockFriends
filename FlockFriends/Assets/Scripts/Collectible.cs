using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectible : MonoBehaviour
{

    GameObject gameManager;
    PlayerManager pm;

    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        pm = gameManager.GetComponent<PlayerManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            CollectBread();
        }
    }

    void CollectBread()
    {
        Destroy(gameObject);
        pm.breadCrumbs++;
    }
}
