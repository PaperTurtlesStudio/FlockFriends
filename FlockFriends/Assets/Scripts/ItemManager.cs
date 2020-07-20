using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    static public List<Item> AlfansoWearable;
    public List<Item> AlfansoWearables;
    ItemManager itemManager;
    public StoreManager storeManager;
    PlayerManager playerManager;

    public bool runOnce = true;

    private void Awake()
    {
        AlfansoWearable = AlfansoWearables;
    }

    private void Start()
    {
        itemManager = gameObject.GetComponent<ItemManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();

        if (!runOnce)
        {
            SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager);

            if(data != null)
            {
                for (int i = 0; i < AlfansoWearable.Count; i++)
                {
                    AlfansoWearable[i].own = data.ownWearables[i];
                    AlfansoWearable[i].wearing = data.wearWearables[i];
                }
            }
        }
    }

    public void Wearing(int num)
    {
        AlfansoWearable[num].wearing = true;
    }

    public void NotWearing(int num)
    {
        AlfansoWearable[num].wearing = false;
    }

    public void BuyItem(int num)
    {
        if(AlfansoWearable[num].cost <= StoreManager.breadCrumbs)
        {
            storeManager.BuyItems(AlfansoWearable[num].cost);
            AlfansoWearable[num].own = true;
        }
    }
}
