using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SceneManager : MonoBehaviour
{
    [SerializeField] public GameObject[] RoomPanel;
    [SerializeField] GameObject[] CloseUpPanel;
    [SerializeField] GameObject dialoguePanel;
    [SerializeField] Image fadeInOut;


    [SerializeField] GameObject[] Level1OFF;
    [SerializeField] GameObject[] Level1ON;
    [SerializeField] GameObject[] Level2OFF;
    [SerializeField] GameObject[] Level2ON;
    [SerializeField] GameObject[] Level3OFF;
    [SerializeField] GameObject[] Level3ON;
    [SerializeField] GameObject[] Level4OFF;
    [SerializeField] GameObject[] Level4ON;
    [Range(0f,3f)] [SerializeField] float fadeInSeconds = 1.5f;
    [Range(0f,3f)] [SerializeField] float fadeInWaitSeconds = 1f;


    public int currentWallIndex = 0;


    void Awake()
    {
        Screen.SetResolution(1920,1080,true);
    }

    void Start()
    {
        Initialize_Room(currentWallIndex);
    }

    IEnumerator Initialization_FadeIn()
    {
        fadeInOut.gameObject.SetActive(true);
        fadeInOut.color = new Color(0f,0f,0f,1f);
        yield return new WaitForSeconds(fadeInWaitSeconds);
        fadeInOut.DOFade(0f, fadeInSeconds);
        yield return new WaitForSeconds(fadeInSeconds);
        fadeInOut.gameObject.SetActive(false);
    }

    private void Initialize_Room(int startWallIndex)
    {
        StartCoroutine(Initialization_FadeIn());
        Set_Room_Panel(currentWallIndex);

        for(int i = 0; i < CloseUpPanel.Length; i++)
        {
            CloseUpPanel[i].SetActive(false);
        }
    }

    private void LevelLoad(int level)
    {
        if(level == 1)
        {
            for(int i = 0; i < Level1OFF.Length; i++)
            {
                Level1OFF[i].SetActive(false);
            }
            for(int i = 0; i < Level1ON.Length; i++)
            {
                Level1ON[i].SetActive(true);
            }
        }
        else if(level == 2)
        {
            for(int i = 0; i < Level2OFF.Length; i++)
            {
                Level2OFF[i].SetActive(false);
            }
            for(int i = 0; i < Level2ON.Length; i++)
            {
                Level2ON[i].SetActive(true);
            }
        }
        else if(level == 3)
        {
            for(int i = 0; i < Level3OFF.Length; i++)
            {
                Level3OFF[i].SetActive(false);
            }
            for(int i = 0; i < Level3ON.Length; i++)
            {
                Level3ON[i].SetActive(true);
            }
        }
        else if(level == 4)
        {
            for(int i = 0; i < Level4OFF.Length; i++)
            {
                Level4OFF[i].SetActive(false);
            }
            for(int i = 0; i < Level4ON.Length; i++)
            {
                Level4ON[i].SetActive(true);
            }
        }

    }


    private void Set_Room_Panel(int index){
        for(int i = 0; i < RoomPanel.Length; i++){
            if(i != index)
            {
                RoomPanel[i].SetActive(false);
            }
            else
            {
                RoomPanel[i].SetActive(true);
            }
        }
    }


    public void OnClick_RightArrow(){
        if(currentWallIndex >= RoomPanel.Length - 1)
            currentWallIndex = 0;
        else
            currentWallIndex++;


            Set_Room_Panel(currentWallIndex);
    }

    public void OnClick_LeftArrow(){
        if(currentWallIndex <= 0)
            currentWallIndex = RoomPanel.Length - 1;
        else
            currentWallIndex--;


        Set_Room_Panel(currentWallIndex);
    }

    public void DialogueTrigger(List<KeyValuePair<string, string>> param)
    {

        dialoguePanel.SetActive(true);
        dialoguePanel.GetComponent<Dialogue>().StartDialogue(param);

    }


}
