using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OstarItemManager : MonoBehaviour
{
    public GameObject GameManager;
    public ItemManager itemManager;

    public SpriteRenderer OstarSpriteRenderer;

    public GameObject WearableItem;


    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        itemManager = GameManager.GetComponent<ItemManager>();

        WearingItem();
    }

    public void WearingItem()
    {
        for (int i = 0; i < ItemManager.OstarWearable.Count; i++)
        {
            if (ItemManager.OstarWearable[i].wearing == true)
            {
                OstarSpriteRenderer.sprite = ItemManager.OstarWearable[i].image;
            }
        }
    }
}
