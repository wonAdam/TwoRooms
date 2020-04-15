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


    [Range(0f,3f)] [SerializeField] float fadeInSeconds = 1.5f;
    [Range(0f,3f)] [SerializeField] float fadeInWaitSeconds = 1f;

    [SerializeField] A_1_Answer a_1_Answer = null;
    [SerializeField] A_2_Answer a_2_Answer = null;
    [SerializeField] A_3_Answer a_3_Answer = null;
    [SerializeField] B_1_Answer b_1_Answer = null;
    [SerializeField] B_2_Answer b_2_Answer = null;
    [SerializeField] B_3_Answer b_3_Answer = null;

    public int currentWallIndex = 0;

    public SaveManager saveManager;

    public bool shouldTutor = false;

    enum Room { A, B };
    [SerializeField] Room thisRoom;

    void Awake()
    {
        saveManager = FindObjectOfType<SaveManager>();

        foreach(TutorialEnable te in Resources.FindObjectsOfTypeAll<TutorialEnable>())
        {
            te.enabled = false;
        }

        Screen.SetResolution(1920,1080,true);
    }

    void Start()
    {
        if(saveManager.IsSaveFile())
        {
            Debug.Log("Save있음");
            Resources.FindObjectsOfTypeAll<TutorialEnder>()[0].EndTutorial();
        }
        else
        {
            Debug.Log("Save없음");
        }


        Initialize_Room(currentWallIndex);        
    }

    IEnumerator Initialization_FadeIn()
    {
        fadeInOut.gameObject.SetActive(true);
        fadeInOut.color = new Color(0f,0f,0f,1f);
        yield return new WaitForSeconds(fadeInWaitSeconds);
        fadeInOut.DOFade(0f, fadeInSeconds);
        yield return new WaitForSeconds(fadeInSeconds);

        //Tutorial 시작

        //세이브 파일이 없으면
        if(shouldTutor)
        {

            //튜토리얼 시작
            FindObjectOfType<TutorialManager>().StartOfTutorial();               
            
            
            foreach(TutorialEnable te in Resources.FindObjectsOfTypeAll<TutorialEnable>())
            {
                te.enabled = true;
            }            
            
     
        }



        fadeInOut.gameObject.SetActive(false);


    }

    private void Initialize_Room(int startWallIndex)
    {

        Set_Room_Panel(currentWallIndex);

        for(int i = 0; i < CloseUpPanel.Length; i++)
        {
            CloseUpPanel[i].SetActive(false);
        }


        //Load
        if(saveManager.IsSaveFile())
        {            
            shouldTutor = false;
            if(thisRoom == Room.A)
                A_LevelLoad(saveManager.Load().level);
            else
            {
                B_LevelLoad(saveManager.Load().level);
                BookLoad(saveManager.Load().book);
            }
        }
        else
        {

            shouldTutor = true;
            if(thisRoom == Room.A)
                saveManager.Save('A', 0);
            else
                saveManager.Save('B', 0);

        }

        StartCoroutine(Initialization_FadeIn());

    }

    [SerializeField] OpenNextBook[] openNextBooks;
    public void BookLoad(int indexBook)
    {
        if(indexBook == 0) return;

        foreach(OpenNextBook onb in openNextBooks)
        {
            if(onb.indexOfThisBook <= indexBook)
            {
                onb.gameObject.SetActive(true);
            }
        }


    }

    public void A_LevelLoad(int level)
    {
        if(level >= 1)
        {
            a_1_Answer.LoadThisUnlocked();
        }
        if(level >= 2)
        {
            a_2_Answer.LoadThisUnlocked();
        }
        if(level >= 3)
        {
            a_3_Answer.LoadThisUnlocked();
        }
    }
    public void B_LevelLoad(int level)
    {
        if(level >= 1)
        {
            b_1_Answer.LoadThisUnlocked();
        }
        if(level >= 2)
        {
            b_2_Answer.LoadThisUnlocked();
        }
        if(level >= 3)
        {
            b_3_Answer.LoadThisUnlocked();
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
