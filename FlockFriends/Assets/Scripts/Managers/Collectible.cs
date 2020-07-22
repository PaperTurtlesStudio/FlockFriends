using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Collectible : MonoBehaviour
{
    public StoreManager storeManager;
    GameObject gameManager;
    PlayerManager pm;

    
    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("GameManager");
        pm = gameManager.GetComponent<PlayerManager>();
        storeManager = gameManager.GetComponent<StoreManager>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Player")
        {
            storeManager.CollectBread(gameObject);
        }
    }

    
}
