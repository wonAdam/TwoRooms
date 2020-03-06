using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class B_1_Answer : MonoBehaviour
{
    [SerializeField] Number first;
    [SerializeField] Number second;
    [SerializeField] Number third;
    [SerializeField] Number forth;

    [SerializeField] int answer1;
    [SerializeField] int answer2;
    [SerializeField] int answer3;
    [SerializeField] int answer4;
    [SerializeField] GameObject _FadeInOut;
    [SerializeField] GameObject _AfterAnswer;
    [SerializeField] CloseUp _Room_d;
    [SerializeField] AudioClip click;

    public void CheckAnswer(){
        if(first.startIndex == answer1 && 
        second.startIndex == answer2 &&
        third.startIndex == answer3 &&
        forth.startIndex == answer4)
        {
            StartCoroutine(SetForAfterAnswer());
        }
    }

    IEnumerator SetForAfterAnswer()
    {
        GetComponent<AudioSource>().PlayOneShot(click);
        _FadeInOut.SetActive(true);
        _FadeInOut.GetComponent<Image>().DOFade(1f, 1f);
        yield return new WaitForSeconds(1f);
        
        _AfterAnswer.SetActive(true);
        _Room_d.Panel_to_CloseUp[1] = _AfterAnswer;
        FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
        FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(0.15f, 2f);
        gameObject.SetActive(false);

        _FadeInOut.GetComponent<Image>().DOFade(0f, 0.5f);
        yield return new WaitForSeconds(0.5f);
        _FadeInOut.SetActive(false);
    }


}
