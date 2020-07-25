using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class NewGame
{
    //side characters active
    public bool pengoActive;
    public bool ostarActive;
    public bool turtsActive;
    //wearables own
    public bool[] AlfansoWearables;
    public bool[] PengoWearables;
    public bool[] OstarWearables;
    public bool[] TurtsWearables;
    //wearable wearing
    public bool[] AlfansoWearing;
    public bool[] PengoWearing;
    public bool[] OstarWearing;
    public bool[] TurtsWearing;
    //bread counter
    public int bread;

    public string level;

    public bool pauseActive;
    public bool deathActive;

    public bool runOnce;

    public NewGame()
    {
        level = "Forest";

        pengoActive = false;
        ostarActive = false;
        turtsActive = false;

        AlfansoWearables = new bool[8];
        AlfansoWearables[0] = true;
        AlfansoWearables[1] = false;
        AlfansoWearables[2] = false;
        AlfansoWearables[3] = false;
        AlfansoWearables[4] = false;
        AlfansoWearables[5] = false;
        AlfansoWearables[6] = false;
        AlfansoWearables[7] = false;

        PengoWearables = new bool[8];
        PengoWearables[0] = true;
        PengoWearables[1] = false;
        PengoWearables[2] = false;
        PengoWearables[3] = false;
        PengoWearables[4] = false;
        PengoWearables[5] = false;
        PengoWearables[6] = false;
        PengoWearables[7] = false;

        OstarWearables = new bool[8];
        OstarWearables[0] = true;
        OstarWearables[1] = false;
        OstarWearables[2] = false;
        OstarWearables[3] = false;
        OstarWearables[4] = false;
        OstarWearables[5] = false;
        OstarWearables[6] = false;
        OstarWearables[7] = false;

        TurtsWearables = new bool[8];
        TurtsWearables[0] = true;
        TurtsWearables[1] = false;
        TurtsWearables[2] = false;
        TurtsWearables[3] = false;
        TurtsWearables[4] = false;
        TurtsWearables[5] = false;
        TurtsWearables[6] = false;
        TurtsWearables[7] = false;


        AlfansoWearing = new bool[8];
        AlfansoWearing[0] = true;
        AlfansoWearing[1] = false;
        AlfansoWearing[2] = false;
        AlfansoWearing[3] = false;
        AlfansoWearing[4] = false;
        AlfansoWearing[5] = false;
        AlfansoWearing[6] = false;
        AlfansoWearing[7] = false;

        PengoWearing = new bool[8];
        PengoWearing[0] = true;
        PengoWearing[1] = false;
        PengoWearing[2] = false;
        PengoWearing[3] = false;
        PengoWearing[4] = false;
        PengoWearing[5] = false;
        PengoWearing[6] = false;
        PengoWearing[7] = false;

        OstarWearing = new bool[8];
        OstarWearing[0] = true;
        OstarWearing[1] = false;
        OstarWearing[2] = false;
        OstarWearing[3] = false;
        OstarWearing[4] = false;
        OstarWearing[5] = false;
        OstarWearing[6] = false;
        OstarWearing[7] = false;


        TurtsWearing = new bool[8];
        TurtsWearing[0] = true;
        TurtsWearing[1] = false;
        TurtsWearing[2] = false;
        TurtsWearing[3] = false;
        TurtsWearing[4] = false;
        TurtsWearing[5] = false;
        TurtsWearing[6] = false;
        TurtsWearing[7] = false;

        bread = 0;

        runOnce = true;
    }
}
