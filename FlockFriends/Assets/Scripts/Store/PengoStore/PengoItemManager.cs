using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PengoItemManager : MonoBehaviour
{
    public GameObject GameManager;
    public ItemManager itemManager;

    public SpriteRenderer PengoSpriteRenderer;

    public GameObject WearableItem;


    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        itemManager = GameManager.GetComponent<ItemManager>();

        WearingItem();
    }

    public void WearingItem()
    {
        for (int i = 0; i < ItemManager.PengoWearable.Count; i++)
        {
            if (ItemManager.PengoWearable[i].wearing == true)
            {
                PengoSpriteRenderer.sprite = ItemManager.PengoWearable[i].image;
            }
        }
    }
}
