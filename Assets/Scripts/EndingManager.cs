using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingManager : MonoBehaviour
{
    [SerializeField] Dialogue dialogue;
    [SerializeField] GameObject[] scenes;
    [SerializeField] GameObject whitePage;

    [TextArea] [SerializeField] List<string> scene_1_character;
    [TextArea] [SerializeField] List<string> scene_1_content;
    [TextArea] [SerializeField] List<string> scene_2_character;
    [TextArea] [SerializeField] List<string> scene_2_content;
    [TextArea] [SerializeField] List<string> scene_3_character;
    [TextArea] [SerializeField] List<string> scene_3_content;
    [TextArea] [SerializeField] List<string> scene_4_character;
    [TextArea] [SerializeField] List<string> scene_4_content;
    [TextArea] [SerializeField] List<string> scene_5_character;
    [TextArea] [SerializeField] List<string> scene_5_content;
    [TextArea] [SerializeField] List<string> scene_6_character;
    [TextArea] [SerializeField] List<string> scene_6_content;
    [TextArea] [SerializeField] List<string> scene_7_character;
    [TextArea] [SerializeField] List<string> scene_7_content;
    [TextArea] [SerializeField] List<string> scene_8_character;
    [TextArea] [SerializeField] List<string> scene_8_content;
    [TextArea] [SerializeField] List<string> scene_9_character;
    [TextArea] [SerializeField] List<string> scene_9_content;    
    
    public void DialogueTrigger(List<KeyValuePair<string, string>> param, int audioclip = 0)
    {

        dialogue.gameObject.SetActive(true);
        dialogue.StartDialogue(param, audioclip);

    }
    public void Scene1_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_1_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_1_character[i], 
                scene_1_content[i])
                );
        }
        DialogueTrigger(param);
    }

    public void Scene3_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_3_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_3_character[i], 
                scene_3_content[i])
                );
        }
        DialogueTrigger(param);
    }
    public void Scene4_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_4_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_4_character[i], 
                scene_4_content[i])
                );
        }
        DialogueTrigger(param);
    }  
    public void Scene5_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_5_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_5_character[i], 
                scene_5_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    public void Scene6_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_6_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_6_character[i], 
                scene_6_content[i])
                );
        }
        DialogueTrigger(param);
    }    
    public void Scene9_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_9_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_9_character[i], 
                scene_9_content[i])
                );
        }
        DialogueTrigger(param);
    }         
    public void sceneActive(int index)
    {
        scenes[index].SetActive(true);
    }

    public void sceneInActive(int index)
    {
        scenes[index].SetActive(false);
    }

    public void Scene2_WrapUp()
    {
        whitePage.SetActive(true);
    }
}
