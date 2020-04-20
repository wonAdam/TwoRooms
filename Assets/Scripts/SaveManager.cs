using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;
using UnityEngine;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveManager : MonoBehaviour
{

    public void Save(char room, int level, int book = 0, bool interview = true)
    {
        // string path = GetPathFromSaveFile();
        // using (FileStream stream = File.Open(path, FileMode.Create)) 
        // {
        //     Data data = new Data(room, level, book);
        //     BinaryFormatter formatter = new BinaryFormatter();
        //     formatter.Serialize(stream, data);
        // }

        Data data = new Data(room, level, book, interview);
        string JsonData = JsonUtility.ToJson(data);

        string path = GetPathFromSaveFile();
        using (FileStream stream = File.Open(path, FileMode.Create))
        {

            byte[] byteData = Encoding.UTF8.GetBytes(JsonData);

            stream.Write(byteData, 0, byteData.Length);

            stream.Close();


            Debug.Log(path + "// save completed");
        }
        
    }

    public Data Load()
    {
        // string path = GetPathFromSaveFile();        
        // using (FileStream stream = File.Open(path, FileMode.Open)) 
        // {
        //     BinaryFormatter formatter = new BinaryFormatter();
        //     Data data = (Data)formatter.Deserialize(stream);

        //     return data;
        // }    


        string path = GetPathFromSaveFile();
        using (FileStream stream = File.Open(path, FileMode.Open))
        {

            byte[] byteData = new byte[stream.Length];

            stream.Read(byteData, 0, byteData.Length);

            stream.Close();

            string JsonData = Encoding.UTF8.GetString(byteData);

            Debug.Log(path + "// load completed");

            return JsonUtility.FromJson<Data>(JsonData);

        }        

    }

    private string GetPathFromSaveFile()
    {
        // return Path.Combine(Application.persistentDataPath, "save.sav");
        return Path.Combine(Application.persistentDataPath, "save.json");
    }

    public bool IsSaveFile()
    {
        // if(File.Exists(Path.Combine(Application.persistentDataPath, "save.sav")))
        // {
        //     return true;
        // }
        // else return false;

        if(File.Exists(Path.Combine(Application.persistentDataPath, "save.json")))
        {
            return true;
        }
        else return false;        
    }

    public void DeleteSaveData()
    {
        // File.Delete(Path.Combine(Application.persistentDataPath, "save.sav"));

        File.Delete(Path.Combine(Application.persistentDataPath, "save.json"));  
    }



}
