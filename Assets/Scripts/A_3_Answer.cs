using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

public class A_3_Answer : MonoBehaviour
{
    [SerializeField] string answer;
    [SerializeField] GameObject afterAnswerPanel;
    [SerializeField] GameObject previousPanel;
    public string buffer = "";

    public SFXManager SFXManager;
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }


    public void CheckIfIsAnswer()
    {
        if(buffer.Length >= 4)
        {
            if(answer == buffer)
            {
                Debug.Log("Correct");
                StartCoroutine(SetForAfterAnswer());
            }
            else
            {
                Debug.Log("Wrong");
                SFXManager.PlaySFX(SFXManager.KeypadWrong);
            }
            buffer = "";
        }
    }
    [SerializeField] GameObject _FadeInOut;

    private IEnumerator SetForAfterAnswer()
    {
        
        AutoSave();

        SFXManager.PlaySFX(SFXManager.VaultOpen);
        
        _FadeInOut.SetActive(true);
        _FadeInOut.GetComponent<Image>().DOFade(1f, 1f);
        yield return new WaitForSeconds(1f);
        
        previousPanel.GetComponent<CloseUp>().Panel_to_CloseUp[0] = afterAnswerPanel;
        afterAnswerPanel.SetActive(true);
        GetComponent<CloseUp>().PreviousPanel = null;

        _FadeInOut.GetComponent<Image>().DOFade(0f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        _FadeInOut.SetActive(false);

        gameObject.SetActive(false);
    }

    public void LoadThisUnlocked()
    {
        previousPanel.GetComponent<CloseUp>().Panel_to_CloseUp[0] = afterAnswerPanel;
        GetComponent<CloseUp>().PreviousPanel = null;
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
            FindObjectOfType<SaveManager>().Save('A', 3,  
                FindObjectOfType<SaveManager>().Load().book);
        }
    }    
    private void DisableSaveUI()
    {
        autoSaveUI.SetActive(false);
    }    

    
}
