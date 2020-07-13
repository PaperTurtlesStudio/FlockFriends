using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class PlayerManager : MonoBehaviour
{
    public int breadCrumbs = 0;
    public GameObject player;
    PlayerMovement playerMove;
    public GameObject restartButton;
    public GameObject sequence;
    SequenceMovement sm;

    public GameObject pengo;
    public GameObject ostar;
    public GameObject turts;

    // Start is called before the first frame update
    void Start()
    {
        playerMove = player.GetComponent<PlayerMovement>();
        sm = sequence.GetComponent<SequenceMovement>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void CharacterDeath(GameObject collision)
    {
        Destroy(collision.gameObject);
        playerMove.speed = 0;
        sm.speed = 0;

        //open up death menu
        restartButton.SetActive(true);

        //pause sequence movement
    }

    public void PauseGame()
    {
        //pause movement
        //bring up mouse
        //allow for clicking on buttons
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
