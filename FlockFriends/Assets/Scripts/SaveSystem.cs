using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveSystem
{
    public static void SavePlayer(ItemManager items, PlayerManager playerManager, StoreManager storeManager)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/player.save";

        FileStream stream = new FileStream(path, FileMode.Create);

        SavePlayer data = new SavePlayer(items, playerManager, storeManager);

        formatter.Serialize(stream, data);
        stream.Close();
    }

    public static SavePlayer LoadPlayer(ItemManager items, PlayerManager playerManager, StoreManager storeManager)
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
            SavePlayer data = new SavePlayer(items, playerManager, storeManager);
            formatter.Serialize(stream, data);
            stream.Close();
            return data;
        }
    }
}
