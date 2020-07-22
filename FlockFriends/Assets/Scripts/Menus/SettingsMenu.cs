using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingsMenu : MonoBehaviour
{
    SettingsMenu settingsMenu;
    public AudioMixer audioMixer;
    Resolution[] resolutions;
    public Dropdown resDropdown;
    public Slider volumeSlider;
    public Toggle muteToggle;
    public Toggle FullScreenToggle;
    public bool isMute;
    public bool isFullScreen;
    public float Volume;


    private void Awake()
    {
            SaveOptions data = SaveSystem.LoadOptions(settingsMenu);
            muteToggle.GetComponent<Toggle>().isOn = data.isMute;
            FullScreenToggle.GetComponent<Toggle>().isOn = data.isFullScreen;
            audioMixer.SetFloat("Volume", data.audioMixer);
            volumeSlider.GetComponent<Slider>().value = data.audioMixer;
    }

    private void Start()
    {
        settingsMenu = gameObject.GetComponent<SettingsMenu>();
        resolutions = Screen.resolutions;
        resDropdown.ClearOptions();

        List<string> options = new List<string>();

        int currentResolutionIndex = 0;
        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && 
                resolutions[i].height == Screen.currentResolution.height) 
            {
                currentResolutionIndex = i;
            }
        }
        resDropdown.AddOptions(options);
        resDropdown.value = currentResolutionIndex;
        resDropdown.RefreshShownValue();
    }

    private void Update()
    {
        isMute = muteToggle.GetComponent<Toggle>().isOn;
        isFullScreen = FullScreenToggle.GetComponent<Toggle>().isOn;
    }

    public void SetVolume(float volume)
    {
        Volume = volume;
        if (!isMute) 
        {
            audioMixer.SetFloat("Volume", -80f);
        }
        else
        {
            audioMixer.SetFloat("Volume", volume);
        }
    }

    public void SetFullScreen(bool isFullScreen)
    {
        if (isFullScreen)
        {
           Screen.fullScreen = isFullScreen;
        }
    }

    public void SetResolution(int resolutionIndex) 
    {
        Resolution resolution = resolutions[resolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
    }

    public void BackButton()
    {
        SaveGame();
        SceneManager.LoadScene("Main");
    }

    void SaveGame()
    {
        SaveSystem.SaveOptions(settingsMenu);
    }

}
