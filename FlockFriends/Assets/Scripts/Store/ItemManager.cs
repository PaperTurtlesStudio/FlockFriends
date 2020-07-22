using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    static public List<Item> AlfansoWearable;
    public List<Item> AlfansoWearables;
    static public List<Item> PengoWearable;
    public List<Item> PengoWearables;
    static public List<Item> OstarWearable;
    public List<Item> OstarWearables;
    static public List<Item> TurtsWearable;
    public List<Item> TurtsWearables;

    ItemManager itemManager;
    public StoreManager storeManager;
    PlayerManager playerManager;
    LevelManager levelManager;

    public bool runOnce = true;

    private void Awake()
    {
        if (runOnce)
        {
            AlfansoWearable = AlfansoWearables;
            PengoWearable = PengoWearables;
            OstarWearable = OstarWearables;
            TurtsWearable = TurtsWearables;
        }
    }

    private void Start()
    {
        itemManager = gameObject.GetComponent<ItemManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();
        levelManager = gameObject.GetComponent<LevelManager>();

        if (!runOnce)
        {
            SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager, levelManager);

            if(data != null)
            {
                for (int i = 0; i < AlfansoWearable.Count; i++)
                {
                    AlfansoWearable[i].own = data.AlfansoWearables[i];
                    AlfansoWearable[i].wearing = data.AlfansoWearing[i];

                    PengoWearable[i].own = data.PengoWearables[i];
                    PengoWearable[i].wearing = data.PengoWearing[i];

                    OstarWearable[i].own = data.OstarWearables[i];
                    OstarWearable[i].wearing = data.OstarWearing[i];

                    TurtsWearable[i].own = data.TurtsWearables[i];
                    TurtsWearable[i].wearing = data.TurtsWearing[i];
                }
            }
        }
        runOnce = false;
    }

    public void Wearing(int num, List<Item> wearableList)
    {
        wearableList[num].wearing = true;
    }

    public void NotWearing(int num, List<Item> wearableList)
    {
        wearableList[num].wearing = false;
    }

    public void BuyItem(int num, List<Item> wearableList)
    {
        if(wearableList[num].cost <= StoreManager.breadCrumbs)
        {
            storeManager.BuyItems(wearableList[num].cost);
            wearableList[num].own = true;
        }
    }
}
