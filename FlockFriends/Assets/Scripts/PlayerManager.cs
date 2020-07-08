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
        restartButton.SetActive(true);
        //destroy character
        //pause sequence movement
        //open up death menu
    }

    public void PauseGame()
    {
        //pause movement
        //bring up mouse
        //allow for clicking on buttons
    }

    
}
