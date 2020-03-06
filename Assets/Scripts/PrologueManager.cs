using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;
using UnityEngine.SceneManagement;

public class PrologueManager : MonoBehaviour
{
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] GameObject[] scenes;
    [TextArea] [SerializeField] List<string> scene_1_DialogueCharacter;
    [TextArea] [SerializeField] List<string> scene_1_DialogueContent;
    [TextArea] [SerializeField] List<string> scene_2_DialogueCharacter;
    [TextArea] [SerializeField] List<string> scene_2_DialogueContent;
    [TextArea] [SerializeField] List<string> scene_4_DialogueCharacter;
    [TextArea] [SerializeField] List<string> scene_4_DialogueContent;
    [TextArea] [SerializeField] List<string> scene_5_DialogueCharacter;
    [TextArea] [SerializeField] List<string> scene_5_DialogueContent;
    [TextArea] [SerializeField] List<string> scene_6_DialogueCharacter;
    [TextArea] [SerializeField] List<string> scene_6_DialogueContent;    
    public void Scene1DialogueStart()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
        for(int i = 0 ; i < scene_1_DialogueCharacter.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_1_DialogueCharacter[i], 
                scene_1_DialogueContent[i])
                );
        }

        DialogueTrigger(param, 1);
    }

    public void SetSceneActive(int i)
    {
        scenes[i].SetActive(true);
    }
    public void SetSceneInactive(int i)
    {
        scenes[i].SetActive(false);
    }

    public void Scene2DialogueStart()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
        for(int i = 0 ; i < scene_2_DialogueCharacter.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_2_DialogueCharacter[i], 
                scene_2_DialogueContent[i])
                );
        }

        DialogueTrigger(param, 2);
    }

    public void Scene4DialogueStart()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
        for(int i = 0 ; i < scene_4_DialogueCharacter.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_4_DialogueCharacter[i], 
                scene_4_DialogueContent[i])
                );
        }

        DialogueTrigger(param, 4);
    }

    public void Scene5DialogueStart()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
        for(int i = 0 ; i < scene_5_DialogueCharacter.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_5_DialogueCharacter[i], 
                scene_5_DialogueContent[i])
                );
        }

        DialogueTrigger(param, 5);
    }
    public void Scene6DialogueStart()
    {
        List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
        for(int i = 0 ; i < scene_6_DialogueCharacter.Count; i++)
        {
            param.Add(new KeyValuePair<string, string>(
                scene_6_DialogueCharacter[i], 
                scene_6_DialogueContent[i])
                );
        }

        DialogueTrigger(param, 6);
    }
    public void TryToOpenDoor()
    {
        scenes[3].transform.DOPunchPosition(new Vector3(-100,-100,0), 1f, 10, 0f);
    }

    public void KnockTheDoorHard()
    {
        scenes[4].transform.DOPunchScale(new Vector3(-0.4f,-0.4f,0), 0.5f, 20, 0f);
    }

    public void DialogueTrigger(List<KeyValuePair<string, string>> param, int scene_num = 0)
    {

        dialoguePanel.SetActive(true);
        dialoguePanel.GetComponent<Dialogue>().StartDialogue(param, scene_num);

    }

    public void FadeOut()
    {
        scenes[5].GetComponent<Image>().color = new Color(0f,0f,0f,1f);
    }

    public void LoadToARoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("A_Room_Scene");
    }
}
