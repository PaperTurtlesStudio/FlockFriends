using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OstarWearableDisplay : MonoBehaviour
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

        price.text = ItemManager.OstarWearable[ListNumber].cost.ToString();
        wearableSprite.sprite = ItemManager.OstarWearable[ListNumber].image;
        wearableSpriteDemo.sprite = ItemManager.OstarWearable[ListNumber].image;
    }
    private void Update()
    {
        for (int i = 0; i < 8; i++)
        {
            if (ItemManager.OstarWearable[i].own)
            {
                if (ListNumber == i)
                {
                    PurchaseCover.gameObject.SetActive(true);
                }
            }
        }
    }

    public void WearOstarItem()
    {
        if (wearableSpriteDemo.gameObject.activeInHierarchy == true && ItemManager.OstarWearable[ListNumber].own == true)
        {
            itemManager.Wearing(ListNumber, ItemManager.OstarWearable);
        }
        else
        {
            itemManager.NotWearing(ListNumber, ItemManager.OstarWearable);
        }
    }
    public void BuyOstarItem()
    {
        if (wearableSpriteDemo.gameObject.activeInHierarchy == true)
        {
            itemManager.BuyItem(ListNumber, ItemManager.OstarWearable);
        }
    }
}
