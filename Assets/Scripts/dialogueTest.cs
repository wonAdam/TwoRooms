using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dialogueTest : MonoBehaviour
{
    [SerializeField] SceneManager sceneManager;

    [SerializeField] string[] speakers;

    [SerializeField] string[] contents;

    public void OnClick_Btn()
    {

        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < speakers.Length; i++)
        {

            KeyValuePair<string, string> item = new KeyValuePair<string, string>(speakers[i], contents[i]);
            param.Add(item);

        }

        sceneManager.DialogueTrigger(param);

    }
}
