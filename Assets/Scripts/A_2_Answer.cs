using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class A_2_Answer : MonoBehaviour
{
    
    [SerializeField] int[] answer;
    [SerializeField] Number[] num;

    [SerializeField] SceneManager sceneManager;
    [SerializeField] GameObject _Room_b_Opened;
    [SerializeField] GameObject _Room_b_Closed;
    [SerializeField] CloseUp LowDrawerLockPanel_LowDrawerLock;
    [SerializeField] GameObject afterAnswer;
    
    
    
    public SFXManager SFXManager;
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }

    public void IsItAnswer()
    {

        for(int i = 0; i < num.Length; i++)
        {
            if(num[i].startIndex != answer[i])
            {
                return;
            }
        }
        StartCoroutine(ItIsAnswer());
    }

    [SerializeField] GameObject _FadeInOut;
    public IEnumerator ItIsAnswer()
    {

        AutoSave();

        _FadeInOut.SetActive(true);
        _FadeInOut.GetComponent<Image>().DOFade(1f, 1f);
        yield return new WaitForSeconds(1f);
        
        SFXManager.PlaySFX(SFXManager.LockOpen1);

        FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
        FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(0.15f, 2f);
        sceneManager.RoomPanel[1] = _Room_b_Opened;
        _Room_b_Closed.SetActive(false);
        LowDrawerLockPanel_LowDrawerLock.PreviousPanel = null;
        _Room_b_Opened.SetActive(true);
        afterAnswer.SetActive(true);
        
        _FadeInOut.GetComponent<Image>().DOFade(0f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        _FadeInOut.SetActive(false);
        gameObject.SetActive(false);

    }
    
    public void LoadThisUnlocked()
    {
        sceneManager.RoomPanel[1] = _Room_b_Opened;
        LowDrawerLockPanel_LowDrawerLock.PreviousPanel = null;
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
            FindObjectOfType<SaveManager>().Save('A', 2);
        }
    }    
    private void DisableSaveUI()
    {
        autoSaveUI.SetActive(false);
    }    

}
