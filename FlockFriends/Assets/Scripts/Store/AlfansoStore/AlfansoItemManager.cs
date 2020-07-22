using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AlfansoItemManager : MonoBehaviour
{
    public GameObject GameManager;
    public ItemManager itemManager;

    public SpriteRenderer alfansoSpriteRenderer;

    public GameObject WearableItem;


    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        itemManager = GameManager.GetComponent<ItemManager>();

        WearingItem();
    }
    
    public void WearingItem()
    {
        for (int i = 0; i < ItemManager.AlfansoWearable.Count; i++)
        {
            if (ItemManager.AlfansoWearable[i].wearing == true)
            {
                alfansoSpriteRenderer.sprite = ItemManager.AlfansoWearable[i].image;
            }
        }
    }
}
