using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Android;

public class MenuManager : MonoBehaviour
{

    [SerializeField] Button continueBtn;
    [SerializeField] SaveLossMessage saveLossMessage;

    [SerializeField] Text debugText;

    public SFXManager SFXManager;


    void Start()
    {
        ///세이브 파일을 확인하여 이어하기 버튼의 interactable여부를 결정
        Screen.SetResolution(1920,1080,FullScreenMode.FullScreenWindow);

        if(UnityEngine.Android.Permission.HasUserAuthorizedPermission(Permission.ExternalStorageRead))
        {
        }
        else
        {
            UnityEngine.Android.Permission.RequestUserPermission(Permission.ExternalStorageRead);
        }

        SFXManager = FindObjectOfType<SFXManager>();
        if(FindObjectOfType<SaveManager>().IsSaveFile())
        {
            continueBtn.interactable = true;


            //debug
            debugText.text = "";
            debugText.text += FindObjectOfType<SaveManager>().Load().Room + " " + FindObjectOfType<SaveManager>().Load().level.ToString();
        }
        else
        {
            continueBtn.interactable = false;
        }
        
    }

    public void ClickSFX()
    {
        SFXManager.PlaySFX(SFXManager.Click);
    }

    public void SlideSFX()
    {
        SFXManager.PlaySFX(SFXManager.PaperFlip1);
    }

    public void OnClick_Start()
    {

        SFXManager.PlaySFX(SFXManager.Click);
        if(FindObjectOfType<SaveManager>().IsSaveFile())
        {
            saveLossMessage.OpenWindow();
            return;

        }
        else
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("DescriptionScene");
        }
    }
    public void OnClick_Continue()
    {
        SFXManager.PlaySFX(SFXManager.Click);
        Data data = FindObjectOfType<SaveManager>().Load();

        //if(A의 세이브자료가 있으면) //UnityEngine.SceneManagement.SceneManager.LoadScene("A_Room_Scene");
        if(data.Room.Equals('A'))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("A_Room_Scene");
        }
        //else if(B의 세이브자료가 있으면) //UnityEngine.SceneManagement.SceneManager.LoadScene("B_Room_Scene");
        else if(data.Room.Equals('B'))
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene("B_Room_Scene");
        }
    }

    public void OnClick_Quit()
    {
        SFXManager.PlaySFX(SFXManager.Click);
        Application.Quit();
    }


}
