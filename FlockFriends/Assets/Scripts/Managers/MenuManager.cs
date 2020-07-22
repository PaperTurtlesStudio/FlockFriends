using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("Main");
    }
    public void QuitGame()
    {
        Application.Quit();
    }
    public void OptionsMenu()
    {
        SceneManager.LoadScene("Options");
    }
    public void PlayGame()
    {
        SceneManager.LoadScene("Level");
    }
    public void LoadStore()
    {
        SceneManager.LoadScene("Store");
    }
}
