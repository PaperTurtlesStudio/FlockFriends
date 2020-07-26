using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayScreen : MonoBehaviour
{
    public GameObject HowTo;
    public GameObject BreadText;
    public ItemManager itemManager;
    public PlayerManager playerManager;
    public StoreManager storeManager;
    public LevelManager levelmanager;

    // Update is called once per frame
    void Update()
    {
        SavePlayer data = SaveSystem.LoadPlayer(itemManager, playerManager, storeManager, levelmanager);
        if (data.runOnce)
        {
            HowTo.SetActive(false);
        }
        else
        {
            StartCoroutine(DeactitivateScreen());
        }
    }

    IEnumerator DeactitivateScreen()
    {
        yield return new WaitForSeconds(7f);

        HowTo.SetActive(false);
        BreadText.SetActive(true);
    }
}
