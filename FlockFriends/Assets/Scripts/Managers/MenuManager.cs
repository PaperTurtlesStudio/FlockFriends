using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public SettingsMenu settingsMenu;
    public ItemManager itemManager;
    public PlayerManager playerManager;
    public StoreManager storeManager;
    public LevelManager levelManager;
    public AudioSource onClickSound;
    public AudioSource onHoverSound;


    public void PlayClickSound()
    {
        if (onClickSound)
        {
            onClickSound.Play();
        }
    }

    public void PlayOnHover()
    {
        if (onHoverSound)
        {
            onHoverSound.Play();
        }
    }

    public void MainMenu()
    {
        SceneManager.LoadScene("Main");
        if (settingsMenu)
        {
            SaveSystem.SaveOptions(settingsMenu);
            SaveSystem.SavePlayer(itemManager, playerManager, storeManager, levelManager);
        }
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

    public void NewGameButton()
    {
        SaveSystem.SaveNewGame();
    }
}
