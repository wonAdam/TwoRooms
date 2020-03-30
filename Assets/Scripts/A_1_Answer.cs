using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.UI;

public class A_1_Answer : MonoBehaviour
{
    [SerializeField] DigitalClock digitalClock;
    [SerializeField] int answer1;
    [SerializeField] int answer2;
    [SerializeField] int answer3;
    [SerializeField] int answer4;


    [SerializeField] GameObject _AfterAnswer;
    [SerializeField] GameObject[] _DestroyAfter;
    [SerializeField] CloseUp _Room_c;
    [SerializeField] GameObject[] englishPoemTouch;
    public SFXManager SFXManager;
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }
    [SerializeField] GameObject _FadeInOut;

    public void CheckAnswerTrigger()
    {
        StartCoroutine(CheckAnswer());
    }


    public IEnumerator CheckAnswer(){
        if(digitalClock.hourTenStartNumIndex == answer1 && 
        digitalClock.hourOneStartNumIndex == answer2 &&
        digitalClock.minTenStartNumIndex == answer3 &&
        digitalClock.minOneStartNumIndex == answer4)
        {

            AutoSave();

            _FadeInOut.SetActive(true);
            _FadeInOut.GetComponent<Image>().DOFade(1f, 1f);
            yield return new WaitForSeconds(1f);

            SFXManager.PlaySFX(SFXManager.DigitalClockCrash);

            FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
            FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(0.15f, 2f);
            _AfterAnswer.SetActive(true);
            for(int i = 0 ; i < englishPoemTouch.Length; i++)
            {
                englishPoemTouch[i].SetActive(true);
            }

            _Room_c.Panel_to_CloseUp[1] = _AfterAnswer;
            
            yield return new WaitForSeconds(0.5f);
            _FadeInOut.GetComponent<Image>().DOFade(0f, 0.5f);
            yield return new WaitForSeconds(0.5f);
            _FadeInOut.SetActive(false);

            for(int i = 0; i < _DestroyAfter.Length; i++)
            {

                _DestroyAfter[i].SetActive(false);

            }        }
    }

    public void LoadThisUnlocked()
    {
        for(int i = 0 ; i < englishPoemTouch.Length; i++)
        {
            englishPoemTouch[i].SetActive(true);
        }  
        _Room_c.Panel_to_CloseUp[1] = _AfterAnswer;

    }

    [SerializeField] GameObject autoSaveUI = null;

    private void AutoSave()
    {
        if(autoSaveUI != null)
        {
            autoSaveUI.SetActive(true);
            Invoke("DisableSaveUI", 3f);
        }

        if(FindObjectOfType<SaveManager>().Load().level < 1)
        {
            FindObjectOfType<SaveManager>().Save('A', 1);
        }
    }

    private void DisableSaveUI()
    {
        autoSaveUI.SetActive(false);
    }    
}
