using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurtsItemManager : MonoBehaviour
{
    public GameObject GameManager;
    public ItemManager itemManager;

    public SpriteRenderer TurtsSpriteRenderer;

    public GameObject WearableItem;


    private void Start()
    {
        GameManager = GameObject.Find("GameManager");
        itemManager = GameManager.GetComponent<ItemManager>();

        WearingItem();
    }

    public void WearingItem()
    {
        for (int i = 0; i < ItemManager.TurtsWearable.Count; i++)
        {
            if (ItemManager.TurtsWearable[i].wearing == true)
            {
                TurtsSpriteRenderer.sprite = ItemManager.TurtsWearable[i].image;
            }
        }
    }
}
