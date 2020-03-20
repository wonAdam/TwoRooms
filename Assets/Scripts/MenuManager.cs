using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{

    [SerializeField] Button continueBtn;
    [SerializeField] SaveLossMessage saveLossMessage;

    [SerializeField] Text debugText;


    void Start()
    {
        debugText.text = PlayerPrefs.GetInt("A", 99).ToString() + "\n" + PlayerPrefs.GetInt("B" , 99).ToString();
        if(PlayerPrefs.GetInt("A", 99) < 4 || PlayerPrefs.GetInt("B" , 99) < 4) 
        {
            continueBtn.interactable = true;
        }
        else 
        {
            continueBtn.interactable = false;
        }
    }
    public void OnClick_Start()
    {
        if(PlayerPrefs.GetInt("A", 99) < 4 || PlayerPrefs.GetInt("B" , 99) < 4)
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
        if(PlayerPrefs.GetInt("A", 99) < 4) UnityEngine.SceneManagement.SceneManager.LoadScene("A_Room_Scene");
        else if(PlayerPrefs.GetInt("B" , 99) < 4) UnityEngine.SceneManagement.SceneManager.LoadScene("B_Room_Scene");
        else continueBtn.interactable = false;
    }

    public void OnClick_Quit()
    {
        Application.Quit();
    }


}
