using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TurtsWearableDisplay : MonoBehaviour
{
    public GameObject StoreManager;
    public StoreManager storeManager;
    public ItemManager itemManager;

    [SerializeField]
    public int ListNumber;

    public Text price;
    public Image wearableSprite;
    public Image wearableSpriteDemo;

    // Start is called before the first frame update
    void Start()
    {
        StoreManager = GameObject.Find("StoreMenu");
        itemManager = StoreManager.GetComponent<ItemManager>();
        storeManager = StoreManager.GetComponent<StoreManager>();

        price.text = ItemManager.TurtsWearable[ListNumber].cost.ToString();
        wearableSprite.sprite = ItemManager.TurtsWearable[ListNumber].image;
        wearableSpriteDemo.sprite = ItemManager.TurtsWearable[ListNumber].image;
    }

    public void WearTurtsItem()
    {
        if (wearableSpriteDemo.gameObject.activeInHierarchy == true && ItemManager.TurtsWearable[ListNumber].own == true)
        {
            itemManager.Wearing(ListNumber, ItemManager.TurtsWearable);
        }
        else
        {
            itemManager.NotWearing(ListNumber, ItemManager.TurtsWearable);
        }
    }

    public void BuyTurtsItem()
    {
        if (wearableSpriteDemo.gameObject.activeInHierarchy == true)
        {
            itemManager.BuyItem(ListNumber, ItemManager.TurtsWearable);
        }
    }
}
