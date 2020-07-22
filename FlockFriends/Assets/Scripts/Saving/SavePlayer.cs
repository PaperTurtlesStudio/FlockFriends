using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class SavePlayer
{
    //side characters active
    public bool pengoActive;
    public bool ostarActive;
    public bool turtsActive;
    //wearables own
    public bool[] AlfansoWearables;
    public bool[] PengoWearables;
    public bool[] OstarWearables;
    public bool[] TurtsWearables;
    //wearable wearing
    public bool[] AlfansoWearing;
    public bool[] PengoWearing;
    public bool[] OstarWearing;
    public bool[] TurtsWearing;
    //bread counter
    public int bread;

    public string level;

    public bool pauseActive;
    public bool deathActive;

    public bool runOnce;

    //constructor
    public SavePlayer(ItemManager items, PlayerManager playerManager, StoreManager storeManager, LevelManager levelManager)
    {
        level = levelManager.Level;

        pengoActive = playerManager.pengo.activeInHierarchy;
        ostarActive = playerManager.ostar.activeInHierarchy;
        turtsActive = playerManager.turts.activeInHierarchy;

        AlfansoWearables = new bool[8];
        AlfansoWearables[0] = ItemManager.AlfansoWearable[0].own;
        AlfansoWearables[1] = ItemManager.AlfansoWearable[1].own;
        AlfansoWearables[2] = ItemManager.AlfansoWearable[2].own;
        AlfansoWearables[3] = ItemManager.AlfansoWearable[3].own;
        AlfansoWearables[4] = ItemManager.AlfansoWearable[4].own;
        AlfansoWearables[5] = ItemManager.AlfansoWearable[5].own;
        AlfansoWearables[6] = ItemManager.AlfansoWearable[6].own;
        AlfansoWearables[7] = ItemManager.AlfansoWearable[7].own;

        PengoWearables = new bool[8];
        PengoWearables[0] = ItemManager.PengoWearable[0].own;
        PengoWearables[1] = ItemManager.PengoWearable[1].own;
        PengoWearables[2] = ItemManager.PengoWearable[2].own;
        PengoWearables[3] = ItemManager.PengoWearable[3].own;
        PengoWearables[4] = ItemManager.PengoWearable[4].own;
        PengoWearables[5] = ItemManager.PengoWearable[5].own;
        PengoWearables[6] = ItemManager.PengoWearable[6].own;
        PengoWearables[7] = ItemManager.PengoWearable[7].own;

        OstarWearables = new bool[8];
        OstarWearables[0] = ItemManager.OstarWearable[0].own;
        OstarWearables[1] = ItemManager.OstarWearable[1].own;
        OstarWearables[2] = ItemManager.OstarWearable[2].own;
        OstarWearables[3] = ItemManager.OstarWearable[3].own;
        OstarWearables[4] = ItemManager.OstarWearable[4].own;
        OstarWearables[5] = ItemManager.OstarWearable[5].own;
        OstarWearables[6] = ItemManager.OstarWearable[6].own;
        OstarWearables[7] = ItemManager.OstarWearable[7].own;

        TurtsWearables = new bool[8];
        TurtsWearables[0] = ItemManager.TurtsWearable[0].own;
        TurtsWearables[1] = ItemManager.TurtsWearable[1].own;
        TurtsWearables[2] = ItemManager.TurtsWearable[2].own;
        TurtsWearables[3] = ItemManager.TurtsWearable[3].own;
        TurtsWearables[4] = ItemManager.TurtsWearable[4].own;
        TurtsWearables[5] = ItemManager.TurtsWearable[5].own;
        TurtsWearables[6] = ItemManager.TurtsWearable[6].own;
        TurtsWearables[7] = ItemManager.TurtsWearable[7].own;


        AlfansoWearing = new bool[8];
        AlfansoWearing[0] = ItemManager.AlfansoWearable[0].wearing;
        AlfansoWearing[1] = ItemManager.AlfansoWearable[1].wearing;
        AlfansoWearing[2] = ItemManager.AlfansoWearable[2].wearing;
        AlfansoWearing[3] = ItemManager.AlfansoWearable[3].wearing;
        AlfansoWearing[4] = ItemManager.AlfansoWearable[4].wearing;
        AlfansoWearing[5] = ItemManager.AlfansoWearable[5].wearing;
        AlfansoWearing[6] = ItemManager.AlfansoWearable[6].wearing;
        AlfansoWearing[7] = ItemManager.AlfansoWearable[7].wearing;

        PengoWearing = new bool[8];
        PengoWearing[0] = ItemManager.PengoWearable[0].wearing;
        PengoWearing[1] = ItemManager.PengoWearable[1].wearing;
        PengoWearing[2] = ItemManager.PengoWearable[2].wearing;
        PengoWearing[3] = ItemManager.PengoWearable[3].wearing;
        PengoWearing[4] = ItemManager.PengoWearable[4].wearing;
        PengoWearing[5] = ItemManager.PengoWearable[5].wearing;
        PengoWearing[6] = ItemManager.PengoWearable[6].wearing;
        PengoWearing[7] = ItemManager.PengoWearable[7].wearing;

        OstarWearing = new bool[8];
        OstarWearing[0] = ItemManager.OstarWearable[0].wearing;
        OstarWearing[1] = ItemManager.OstarWearable[1].wearing;
        OstarWearing[2] = ItemManager.OstarWearable[2].wearing;
        OstarWearing[3] = ItemManager.OstarWearable[3].wearing;
        OstarWearing[4] = ItemManager.OstarWearable[4].wearing;
        OstarWearing[5] = ItemManager.OstarWearable[5].wearing;
        OstarWearing[6] = ItemManager.OstarWearable[6].wearing;
        OstarWearing[7] = ItemManager.OstarWearable[7].wearing;
        
        
        TurtsWearing = new bool[8];
        TurtsWearing[0] = ItemManager.TurtsWearable[0].wearing;
        TurtsWearing[1] = ItemManager.TurtsWearable[1].wearing;
        TurtsWearing[2] = ItemManager.TurtsWearable[2].wearing;
        TurtsWearing[3] = ItemManager.TurtsWearable[3].wearing;
        TurtsWearing[4] = ItemManager.TurtsWearable[4].wearing;
        TurtsWearing[5] = ItemManager.TurtsWearable[5].wearing;
        TurtsWearing[6] = ItemManager.TurtsWearable[6].wearing;
        TurtsWearing[7] = ItemManager.TurtsWearable[7].wearing;

        bread = storeManager.GetBread();

        runOnce = true;
    }
}
