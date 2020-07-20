using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    static public int breadCrumbs = 0;
    public ItemManager itemManager;
    StoreManager storeManager;
    PlayerManager playerManager;


    void Start()
    {
        storeManager = gameObject.GetComponent<StoreManager>();
        itemManager = gameObject.GetComponent<ItemManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();

        
        
        SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager);
        if (data != null)
        {
            breadCrumbs = data.bread;
        }
        

    }

    public void CollectBread(GameObject obj)
    {
        Destroy(obj);
        breadCrumbs++;
    }

    public void UpdateBreadAmount(Text text)
    {
        text.text = breadCrumbs.ToString();
    }

    public void BuyItems(int price)
    {
        breadCrumbs -= price;
    }

    public int GetBread()
    {
        int bread = breadCrumbs;
        return bread;
    }
}
