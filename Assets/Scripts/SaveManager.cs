using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{

    public void Save(char room, int level, int book = 0)
    {
        string path = GetPathFromSaveFile();
        using (FileStream stream = File.Open(path, FileMode.Create)) 
        {
            Data data = new Data(room, level, book);
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, data);
        }
        
        
    }

    public Data Load()
    {
        string path = GetPathFromSaveFile();        
        using (FileStream stream = File.Open(path, FileMode.Open)) 
        {
            BinaryFormatter formatter = new BinaryFormatter();
            Data data = (Data)formatter.Deserialize(stream);

            return data;
        }    

    }

    private string GetPathFromSaveFile()
    {
        return Path.Combine(Application.persistentDataPath, "save.sav");
    }

    public bool IsSaveFile()
    {
        if(File.Exists(Path.Combine(Application.persistentDataPath, "save.sav")))
        {
            return true;
        }
        else return false;
    }

    public void DeleteSaveData()
    {
        File.Delete(Path.Combine(Application.persistentDataPath, "save.sav"));
    }



}
