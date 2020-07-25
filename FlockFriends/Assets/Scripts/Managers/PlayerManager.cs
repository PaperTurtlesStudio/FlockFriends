using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public StoreManager storeManager;
    LevelManager levelmanager;
    public GameObject player;
    PlayerMovement playerMove;
    public GameObject deathMenu;
    public GameObject pauseMenu;
    SequenceManager sequenceManager;
    ItemManager itemManager;
    PlayerManager playerManager;
    MenuManager menuManager;

    public bool PauseMenu;
    public bool DeathMenu;

    public GameObject pengo;
    public GameObject ostar;
    public GameObject turts;

    // Start is called before the first frame update
    void Start()
    {
        playerMove = player.GetComponent<PlayerMovement>();
        sequenceManager = gameObject.GetComponent<SequenceManager>();
        storeManager = gameObject.GetComponent<StoreManager>();
        itemManager = gameObject.GetComponent<ItemManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();
        levelmanager = gameObject.GetComponent<LevelManager>();
        menuManager = gameObject.GetComponent<MenuManager>();

        SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager, levelmanager);
        if (data.pengoActive)
        {
            pengo.SetActive(data.pengoActive);
            ostar.SetActive(data.ostarActive);
            turts.SetActive(data.turtsActive);

        }

        pauseMenu.SetActive(data.pauseActive);
        deathMenu.SetActive(data.deathActive);
    }

    private void Update()
    {
        PauseMenu = pauseMenu.activeInHierarchy;
        DeathMenu = deathMenu.activeInHierarchy;
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
        SaveSystem.SavePlayer(itemManager, playerManager, storeManager, levelmanager);
    }
}
