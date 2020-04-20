using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_3_Answer : MonoBehaviour
{
    [Tooltip("Row Major Order")] [SerializeField] GameObject[] btns;

    [SerializeField] int[] answer;
    [SerializeField] GameObject afterAnswerPanel;
    [SerializeField] GameObject previousPanel;


    public void CheckIfIsAnswer()
    {
        for(int i = 0 ; i < btns.Length; i++)
        {
            // O 인데
            if(btns[i].transform.GetComponentInChildren<ScrollSelection_Mgr>().imgIndex == 2)
            {
                bool isAnswer = false;
                for(int j = 0; j < answer.Length; j++)
                {
                    if(i == answer[j])
                    {
                        isAnswer = true;
                    }
                }
                // 정답이 아니면
                if(isAnswer == false) return;
                isAnswer = false;
            }
            // O 아닌데
            else
            {
                bool isAnswer = false;
                for(int j = 0; j < answer.Length; j++)
                {
                    if(i == answer[j])
                    {
                        isAnswer = true;
                    }                
                }
                //정답이면
                if(isAnswer == true) return;
                isAnswer = false;
            }
        }
        SetForAfterAnswer();
    }

    private void SetForAfterAnswer()
    {

        AutoSave();

        previousPanel.GetComponent<CloseUp>().Panel_to_CloseUp[0] = afterAnswerPanel;
        afterAnswerPanel.SetActive(true);
        previousPanel = null;
        gameObject.SetActive(false);
    }

    public void LoadThisUnlocked()
    {
        previousPanel.GetComponent<CloseUp>().Panel_to_CloseUp[0] = afterAnswerPanel;
        previousPanel = null;
    }

    [SerializeField] GameObject autoSaveUI = null;

    private void AutoSave()
    {
        if(autoSaveUI != null)
        {
            autoSaveUI.SetActive(true);
            Invoke("DisableSaveUI", 3f);
        }

        if(FindObjectOfType<SaveManager>().Load().level < 3)
        {
            FindObjectOfType<SaveManager>().Save('B', 3, 
                FindObjectOfType<SaveManager>().Load().book, 
                FindObjectOfType<SaveManager>().Load().interview);
        }
    }    
    private void DisableSaveUI()
    {
        autoSaveUI.SetActive(false);
    }    

}
