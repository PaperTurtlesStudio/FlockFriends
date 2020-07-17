using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WearableItemDisplay : MonoBehaviour
{
    public GameObject StoreManager;
    public StoreManager storeManager;
    public ItemManager itemManager;

    [SerializeField]
    public int ListNumber;

    public Text price;
    public Image wearableSprite;
    public Image wearableSpriteDemo;

    //public AlfansoItemManager AlfansoItemManager;
    // Start is called before the first frame update
    void Start()
    {
        StoreManager = GameObject.Find("StoreMenu");
        itemManager = StoreManager.GetComponent<ItemManager>();
        storeManager = StoreManager.GetComponent<StoreManager>();

        price.text = ItemManager.AlfansoWearable[ListNumber].cost.ToString();
        wearableSprite.sprite = ItemManager.AlfansoWearable[ListNumber].image;
        wearableSpriteDemo.sprite = ItemManager.AlfansoWearable[ListNumber].image;
    }



    public void WearItem()
    {
        if (wearableSpriteDemo.gameObject.activeInHierarchy == true && ItemManager.AlfansoWearable[ListNumber].own == true)
        {
            itemManager.Wearing(ListNumber);
        }
        else
        {
            itemManager.NotWearing(ListNumber);
        }
    }

    public void BuyItem()
    {
        if(wearableSpriteDemo.gameObject.activeInHierarchy == true)
        {
            itemManager.BuyItem(ListNumber);
        }
    }

}
