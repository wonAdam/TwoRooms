using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

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
    [TextArea] [SerializeField] List<string> scene_10_character;
    [TextArea] [SerializeField] List<string> scene_10_content;    
    [TextArea] [SerializeField] List<string> scene_11_character;
    [TextArea] [SerializeField] List<string> scene_11_content;   
    [TextArea] [SerializeField] List<string> scene_12_character;
    [TextArea] [SerializeField] List<string> scene_12_content;   
    [TextArea] [SerializeField] List<string> scene_14_character;
    [TextArea] [SerializeField] List<string> scene_14_content;   
    [TextArea] [SerializeField] List<string> scene_15_character;
    [TextArea] [SerializeField] List<string> scene_15_content;   
    [TextArea] [SerializeField] List<string> scene_17_character;
    [TextArea] [SerializeField] List<string> scene_17_content;   
    [TextArea] [SerializeField] List<string> scene_18_character;
    [TextArea] [SerializeField] List<string> scene_18_content;   
    [TextArea] [SerializeField] List<string> scene_19_character;
    [TextArea] [SerializeField] List<string> scene_19_content;   

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
    public void Scene10_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_10_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_10_character[i], 
                scene_10_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    
    public void Scene11_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_11_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_11_character[i], 
                scene_11_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    public void Scene12_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_12_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_12_character[i], 
                scene_12_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    public void Scene14_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_14_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_14_character[i], 
                scene_14_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    public void Scene15_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_15_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_15_character[i], 
                scene_15_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    public void Scene17_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_17_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_17_character[i], 
                scene_17_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    public void Scene18_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_18_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_18_character[i], 
                scene_18_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    public void Scene19_DialogueTrigger()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();

        for(int i = 0 ; i < scene_19_character.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_19_character[i], 
                scene_19_content[i])
                );
        }
        DialogueTrigger(param);
    }        
    



    public void Scene10_PunchEffect()
    {
        scenes[9].transform.DOPunchPosition(new Vector3(-100f,-100f, 0f), 0.3f, 50, 0);
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
