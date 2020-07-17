using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextUpdate : MonoBehaviour
{

    public Text BreadAmount;
    public StoreManager storeManager;

    // Start is called before the first frame update
    void Start()
    {
        gameObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        storeManager.UpdateBreadAmount(BreadAmount);
    }
}
