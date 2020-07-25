using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowBread : MonoBehaviour
{
    public StoreManager storeManager;
    public Text BreadText;

    // Start is called before the first frame update
    void Start()
    {
        storeManager = gameObject.GetComponent<StoreManager>();
    }

    // Update is called once per frame
    void Update()
    {
        BreadText.text = "Bread: " + storeManager.GetBread().ToString();
    }
}
