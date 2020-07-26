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
    LevelManager levelManager;

    public Image PengoCover;
    public GameObject PengoButton;
    public Image OstarCover;
    public GameObject OstarButton;
    public Image TurtsCover;
    public GameObject TurtsButton;


    void Start()
    {
        storeManager = gameObject.GetComponent<StoreManager>();
        itemManager = gameObject.GetComponent<ItemManager>();
        playerManager = gameObject.GetComponent<PlayerManager>();
        levelManager = gameObject.GetComponent<LevelManager>();

        SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager, levelManager);
        if (data != null)
        {
            breadCrumbs = data.bread;
            PengoCover.gameObject.SetActive(!data.pengoActive);
            PengoButton.SetActive(data.pengoActive);
            OstarCover.gameObject.SetActive(!data.ostarActive);
            OstarButton.SetActive(data.ostarActive);
            TurtsCover.gameObject.SetActive(!data.turtsActive);
            TurtsButton.SetActive(data.turtsActive);
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
