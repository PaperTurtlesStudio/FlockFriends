using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(ItemManager items, PlayerManager playerManager, StoreManager storeManager, LevelManager levelManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";

        FileStream stream = new FileStream(path, FileMode.Create);

        SavePlayer data = new SavePlayer(items, playerManager, storeManager, levelManager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SavePlayer LoadPlayer(ItemManager items, PlayerManager playerManager, StoreManager storeManager, LevelManager levelManager)
    {
        string path = Application.persistentDataPath + "/player.save";
        FileStream stream = new FileStream(path, FileMode.Open);
        if (File.Exists(path) && stream.Length > 0)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            SavePlayer data = formatter.Deserialize(stream) as SavePlayer;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Save file was not found in " + path);
            BinaryFormatter formatter = new BinaryFormatter();
            SavePlayer data = new SavePlayer(items, playerManager, storeManager, levelManager);
            formatter.Serialize(stream, data);
            stream.Close();
            return data;
        }
    }

    public static void SaveNewGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";

        FileStream stream = new FileStream(path, FileMode.Create);

        NewGame data = new NewGame();

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static void SaveOptions(SettingsMenu settingsMenu)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/option.save";

        FileStream stream = new FileStream(path, FileMode.Create);

        SaveOptions data = new SaveOptions(settingsMenu);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SaveOptions LoadOptions(SettingsMenu settingsMenu)
    {
        string path = Application.persistentDataPath + "/option.save";
        FileStream stream = new FileStream(path, FileMode.Open);
        if (File.Exists(path) && stream.Length > 0)
        {
            BinaryFormatter formatter = new BinaryFormatter();

            SaveOptions data = formatter.Deserialize(stream) as SaveOptions;
            stream.Close();

            return data;
        }
        else
        {
            Debug.Log("Save file was not found in " + path);
            BinaryFormatter formatter = new BinaryFormatter();
            SaveOptions data = new SaveOptions(settingsMenu);
            formatter.Serialize(stream, data);
            stream.Close();
            return data;
        }
    }
}
