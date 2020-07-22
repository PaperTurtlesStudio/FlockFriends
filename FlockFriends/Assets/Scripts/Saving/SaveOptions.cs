using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveOptions
{
    public float audioMixer;
    public bool isMute;
    public bool isFullScreen;

    public SaveOptions(SettingsMenu settingsMenu)
    {
        audioMixer = settingsMenu.Volume;
        isMute = settingsMenu.isMute;
        isFullScreen = settingsMenu.isFullScreen;
    }
}
