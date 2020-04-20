using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LaptopMemofile : MonoBehaviour
{
    [SerializeField] GameObject MemoWindow;
    [SerializeField] public GameObject ClickedMark;
    public Vector3 init_pos;
    public bool isOpened = false;
    [SerializeField] public bool isInterview;
    [SerializeField] [TextArea] public string[] character;
    [SerializeField] [TextArea] public string[] content;
    void Start()
    {
        init_pos = MemoWindow.transform.position;
        MemoWindow.transform.localScale = new Vector3(0f,0f,0f);
        ClickedMark.SetActive(false);
    }

    public void MemoOpen()
    {
        if(isOpened == false){
            isOpened = true;
            ClickedMark.SetActive(true);
            MemoWindow.transform.DOScale(new Vector3(1f,1f,1f), 0.3f);
            MemoWindow.transform.DOMove(new Vector3(0f,0f,0f), 0.3f);


            if(isInterview && FindObjectOfType<SaveManager>().Load().interview == true)
            {
                if(character.Length > 0)
                {
                    List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                    for(int i = 0 ; i < character.Length; i++)
                    {
                        param.Add(new KeyValuePair<string, string>(
                            character[i], 
                            content[i])
                            );
                    }
                    Resources.FindObjectsOfTypeAll<Dialogue>()[0].gameObject.SetActive(true);                
                    Resources.FindObjectsOfTypeAll<Dialogue>()[0].StartDialogue(param);
                }

                FindObjectOfType<SaveManager>().Save('B', 
                    FindObjectOfType<SaveManager>().Load().level, 
                    FindObjectOfType<SaveManager>().Load().book, 
                    false);

            }
        }
    }
}
