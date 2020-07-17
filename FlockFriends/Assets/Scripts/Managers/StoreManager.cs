using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    static public int breadCrumbs = 10;

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
