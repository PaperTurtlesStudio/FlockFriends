using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathMenu : MonoBehaviour
{
    public void ReloadLevel()
    {
        SceneManager.LoadScene("Level");   
    }

    public void LoadStore()
    {
        SceneManager.LoadScene("Store");
    }
}
