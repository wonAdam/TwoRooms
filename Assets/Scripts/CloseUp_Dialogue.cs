using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseUp_Dialogue : MonoBehaviour
{
    [SerializeField] List<string> character;
    [SerializeField] List<string> content;
    [SerializeField] public bool restartEndable;

    private bool isFirstTime = false;

    void OnEnable()
    {   
    List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
        for(int i = 0; i < character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(character[i], content[i]));
        }
        if(restartEndable || !isFirstTime)
        {
            FindObjectOfType<SceneManager>().DialogueTrigger(param);
        }
        isFirstTime = true;
    }
}
