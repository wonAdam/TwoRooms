using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_2_Answer : MonoBehaviour
{
    [SerializeField] LaptopPwdPanel laptopPwdPanel;
    [SerializeField] string[] answers;
    [SerializeField] CloseUp laptopSidePanel;
    [SerializeField] GameObject afterAnswerLaptop;


    public SFXManager SFXManager;
    /// <summary>
    /// Start is called on the frame when a script is enabled just before
    /// any of the Update methods is called the first time.
    /// </summary>
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }


    public void CheckAnswer(string input){
        foreach(string answer in answers)
        {

            if(input == answer)
            {
                AutoSave();
                
                Debug.Log("Correct");
                SFXManager.PlaySFX(SFXManager.TurnOn);
                laptopSidePanel.Panel_to_CloseUp[0] = afterAnswerLaptop;
                afterAnswerLaptop.SetActive(true);
                gameObject.SetActive(false);
                laptopSidePanel.gameObject.SetActive(false);
                return;
            }

        }

        Debug.Log("Wrong");

    }

    public void LoadThisUnlocked()
    {
        laptopSidePanel.Panel_to_CloseUp[0] = afterAnswerLaptop;
    }

    [SerializeField] GameObject autoSaveUI = null;

    private void AutoSave()
    {
        if(autoSaveUI != null)
        {
            autoSaveUI.SetActive(true);
            Invoke("DisableSaveUI", 3f);
        }

        if(FindObjectOfType<SaveManager>().Load().level < 2)
        {
            FindObjectOfType<SaveManager>().Save('B', 2, 
                FindObjectOfType<SaveManager>().Load().book, 
                FindObjectOfType<SaveManager>().Load().interview);
        }
    } 
    private void DisableSaveUI()
    {
        autoSaveUI.SetActive(false);
    }    
       
}
