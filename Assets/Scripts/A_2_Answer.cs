using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


public class A_2_Answer : MonoBehaviour
{
    
    [SerializeField] int[] answer;
    [SerializeField] Number[] num;

    [SerializeField] SceneManager sceneManager;
    [SerializeField] GameObject _Room_b_Opened;
    [SerializeField] GameObject _Room_b_Closed;
    [SerializeField] CloseUp LowDrawerLockPanel_LowDrawerLock;

    public void IsItAnswer()
    {

        for(int i = 0; i < num.Length; i++)
        {
            if(num[i].startIndex != answer[i])
            {
                return;
            }
        }
        ItIsAnswer();
    }

    public void ItIsAnswer()
    {

        AutoSave();

        FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
        FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(0.15f, 2f);
        sceneManager.RoomPanel[1] = _Room_b_Opened;
        _Room_b_Closed.SetActive(false);
        LowDrawerLockPanel_LowDrawerLock.PreviousPanel = null;
        LowDrawerLockPanel_LowDrawerLock.gameObject.SetActive(false);
        _Room_b_Opened.SetActive(true);
        LowDrawerLockPanel_LowDrawerLock.gameObject.SetActive(false);

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
            autoSaveUI.GetComponent<Animator>().SetTrigger("Save");
        }

        if(PlayerPrefs.GetInt("A", 99) < 2)
        {
            PlayerPrefs.SetInt("A", 2);
        }
    }    

}
