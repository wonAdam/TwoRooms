using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEngine.UI;

//[System.Serializable]
//private class wrapper
//{
//    public Dialogues[] container;
//}

//[System.Serializable]
//private class Dialogues
//{
//    public string name;
//    public string dialogue;
//}

public class Dialogue_Mgr : MonoBehaviour
{
    public wrapper wr;
    public string path;
    public RawImage dialogWindow;
    public Text dialog_content;
    public Text dialog_name;
    public float normalDialogueSpeed; // 일반적인 대화속도 (코루틴의 변수로 넣거나 더 느린 혹은 빠른 대화를 원할시 그냥 const float 을 넣어줄수있음)
    public int dialogue_index;
    bool isDialoguing;

    void Start()
    {
        dialogue_index = 0;
        path = Path.Combine(Application.dataPath, "Json", "dialogueData.json");
        FromJson(path);
        isDialoguing = false;
    }


    void Update()
    {
        //CharOnebyOne중이 아니고 마우스클릭, 터치를 받으면 다음 대화시작
        if(dialogue_index < wr.container.Length && isDialoguing == false && (Input.GetMouseButtonDown(0) || Input.touchCount > 0))
        {
            dialog_content.text = "";
            dialog_name.text = "";
            StartCoroutine(CharOneByOne(wr.container[dialogue_index], normalDialogueSpeed));
        }
        //대화가 끝나면 대화윈도우해제, 대화매니저도 해제
        if(dialogue_index >= wr.container.Length && (Input.GetMouseButtonDown(0) || Input.touchCount > 0))
        {
            dialogWindow.gameObject.SetActive(false);
            gameObject.SetActive(false);
        }
    }


    //대화 한글자씩 보여주는 코루틴
    IEnumerator CharOneByOne(Dialogues NameNDialogue, float dialogueSpeed)
    {
        isDialoguing = true;
        dialog_name.text = NameNDialogue.name;
        string dialog = "";

        for (int i = 0; i < NameNDialogue.dialogue.Length; i++)
        {
            //if(Input.GetMouseButtonDown(0) || Input.touchCount > 0)
            //{
            //    isDialoguing = false;
            //    for(; i < NameNDialogue.dialogue.Length; i++)
            //    {
            //        dialog += NameNDialogue.dialogue[i];
            //    }
            //    dialog_content.text = dialog;
            //    break;
            //}
             yield return new WaitForSeconds(dialogueSpeed);
             dialog += NameNDialogue.dialogue[i];
             dialog_content.text = dialog;
            
        }
        isDialoguing = false;
        dialogue_index += 1;
    }

    //json데이터를 wrapper객체로 읽어옴 
    public void FromJson(string path)
    {
        string jsonData = File.ReadAllText(path);
        wr = JsonUtility.FromJson<wrapper>(jsonData);
    }



}
