using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public string Level = "Forest";
    public int NumberOfSequences = 5;
    public int AmountSequencesPassed = 0;
    ItemManager itemManager;
    PlayerManager playerManager;
    StoreManager storeManager;
    LevelManager levelmanager;

    // Start is called before the first frame update
    void Start()
    {
        storeManager = gameObject.GetComponent<StoreManager>();
        itemManager = gameObject.GetComponent<ItemManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();
        levelmanager = gameObject.GetComponent<LevelManager>();

        
        SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager, levelmanager);
        Level = data.level;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
