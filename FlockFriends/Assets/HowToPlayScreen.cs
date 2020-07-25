using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlayScreen : MonoBehaviour
{
    public GameObject HowTo;
    public GameObject BreadText;
    
    // Update is called once per frame
    void Update()
    {
        StartCoroutine(DeactitivateScreen());
    }

    IEnumerator DeactitivateScreen()
    {
        yield return new WaitForSeconds(7f);

        HowTo.SetActive(false);
        BreadText.SetActive(true);
    }
}
