using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PengoWearableDisplay : MonoBehaviour
{
    public GameObject StoreManager;
    public StoreManager storeManager;
    public ItemManager itemManager;
    public Image PurchaseCover;

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

        price.text = ItemManager.PengoWearable[ListNumber].cost.ToString();
        wearableSprite.sprite = ItemManager.PengoWearable[ListNumber].image;
        wearableSpriteDemo.sprite = ItemManager.PengoWearable[ListNumber].image;
    }
    private void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            if (ItemManager.PengoWearable[i].own)
            {
                if (ListNumber == i)
                {
                    PurchaseCover.gameObject.SetActive(true);
                }
            }
        }
    }

    public void WearPengoItem()
    {
        if (wearableSpriteDemo.gameObject.activeInHierarchy == true && ItemManager.PengoWearable[ListNumber].own == true)
        {
            itemManager.Wearing(ListNumber, ItemManager.PengoWearable);
        }
        else
        {
            itemManager.NotWearing(ListNumber, ItemManager.PengoWearable);
        }
    }

    public void BuyPengoItem()
    {
        if (wearableSpriteDemo.gameObject.activeInHierarchy == true)
        {
            itemManager.BuyItem(ListNumber, ItemManager.PengoWearable);
        }
    }
}
