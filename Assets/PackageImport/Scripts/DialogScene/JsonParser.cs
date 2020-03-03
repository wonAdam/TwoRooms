using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

[System.Serializable]
public class wrapper
{
    public Dialogues[] container;
}

[System.Serializable]
public class Dialogues
{
    public string name;
    public string dialogue;
}

public class JsonParser : MonoBehaviour
{
    [SerializeField]
    public wrapper wr;

    [ContextMenu("To Json")]
    public void ToJson()
    {
        string path_tojson = Path.Combine(Application.dataPath, "Json", "dialogueData.json");
        string jsonData_tojson = JsonUtility.ToJson(wr);
        File.WriteAllText(path_tojson, jsonData_tojson);
    }
}
