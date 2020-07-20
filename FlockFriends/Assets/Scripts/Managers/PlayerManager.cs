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
    ItemManager itemManager;
    PlayerManager playerManager;

    public GameObject pengo;
    public GameObject ostar;
    public GameObject turts;


    private void Awake()
    {
    }

    // Start is called before the first frame update
    void Start()
    {
        playerMove = player.GetComponent<PlayerMovement>();
        sequenceManager = gameObject.GetComponent<SequenceManager>();
        storeManager = gameObject.GetComponent<StoreManager>();
        itemManager = gameObject.GetComponent<ItemManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();

        if (!itemManager.runOnce)
        {
            SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager);

            if (data != null)
            {
                pengo.SetActive(data.pengoActive);
                ostar.SetActive(data.ostarActive);
                turts.SetActive(data.turtsActive);
            }
        }
    }

    public void CharacterDeath(GameObject collision)
    {
        
        Destroy(collision.gameObject);
        
        
        playerMove.speed = 0;
        sequenceManager.SequenceSpeed = 0;
        
        //open up death menu
        deathMenu.SetActive(true);

        //play death sound
        FindObjectOfType<AudioManager>().Play("PlayerDeath");

        //Save Game
        SaveGame();
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

    void SaveGame()
    {
        SaveSystem.SavePlayer(itemManager, playerManager, storeManager);
    }
}
