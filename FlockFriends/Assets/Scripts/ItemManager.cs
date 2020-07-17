using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemManager : MonoBehaviour
{
    static public List<Item> AlfansoWearable;
    public List<Item> AlfansoWearables;
    public StoreManager storeManager;

    static int runOnce = 0;

    private void Awake()
    {
        if(runOnce == 0)
        {
            AlfansoWearable = AlfansoWearables;
        }
    }

    private void Update()
    {
        
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
        if(AlfansoWearable[num].cost <= storeManager.GetBread())
        {
            storeManager.BuyItems(AlfansoWearable[num].cost);
            AlfansoWearable[num].own = true;
        }
    }
}
