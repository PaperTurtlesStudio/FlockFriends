using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SavePlayer
{
    //Copy down any of the variables to be saved in forms of int, float, string, and bool

    //side characters active
    public bool pengoActive;
    public bool ostarActive;
    public bool turtsActive;
    //wearables own
    public bool[] ownWearables;
    //wearable wearing
    public bool[] wearWearables;
    //bread counter
    public int bread;

    public bool runOnce;

    //constructor

    public SavePlayer(ItemManager items, PlayerManager playerManager, StoreManager storeManager)
    {
        pengoActive = playerManager.pengo.activeInHierarchy;
        ostarActive = playerManager.ostar.activeInHierarchy;
        turtsActive = playerManager.turts.activeInHierarchy;

        ownWearables = new bool[8];
        ownWearables[0] = ItemManager.AlfansoWearable[0].own;
        ownWearables[1] = ItemManager.AlfansoWearable[1].own;
        ownWearables[2] = ItemManager.AlfansoWearable[2].own;
        ownWearables[3] = ItemManager.AlfansoWearable[3].own;
        ownWearables[4] = ItemManager.AlfansoWearable[4].own;
        ownWearables[5] = ItemManager.AlfansoWearable[5].own;
        ownWearables[6] = ItemManager.AlfansoWearable[6].own;
        ownWearables[7] = ItemManager.AlfansoWearable[7].own;

        wearWearables = new bool[8];
        wearWearables[0] = items.AlfansoWearables[0].wearing;
        wearWearables[1] = items.AlfansoWearables[1].wearing;
        wearWearables[2] = items.AlfansoWearables[2].wearing;
        wearWearables[3] = items.AlfansoWearables[3].wearing;
        wearWearables[4] = items.AlfansoWearables[4].wearing;
        wearWearables[5] = items.AlfansoWearables[5].wearing;
        wearWearables[6] = items.AlfansoWearables[6].wearing;
        wearWearables[7] = items.AlfansoWearables[7].wearing;
        
        bread = storeManager.GetBread();

        runOnce = items.runOnce;
    }
}
