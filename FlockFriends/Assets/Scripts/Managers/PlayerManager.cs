using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public StoreManager storeManager;
    public GameObject player;
    PlayerMovement playerMove;
    public GameObject deathMenu;
    SequenceManager sequenceManager;

    public GameObject pengo;
    public GameObject ostar;
    public GameObject turts;

    // Start is called before the first frame update
    void Start()
    {
        playerMove = player.GetComponent<PlayerMovement>();
        sequenceManager = gameObject.GetComponent<SequenceManager>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterDeath(GameObject collision)
    {
        Destroy(collision.gameObject);
        playerMove.speed = 0;
        sequenceManager.SequenceSpeed = 0;
        FindObjectOfType<AudioManager>().Play("PlayerDeath");

        //open up death menu
        deathMenu.SetActive(true);

        //play death sound
    }

    public void AddCharacter()
    {
        if(pengo.activeInHierarchy == false)
        {
            pengo.SetActive(true);
        }
        else if(ostar.activeInHierarchy == false)
        {
            ostar.SetActive(true);
        }
        else if(turts.activeInHierarchy == false)
        {
            turts.SetActive(true);
        }
    }
}
