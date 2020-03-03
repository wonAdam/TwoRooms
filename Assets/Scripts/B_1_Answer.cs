using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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
    [SerializeField] GameObject _AfterAnswer;
    [SerializeField] CloseUp _Room_d;

    public void CheckAnswer(){
        if(first.startIndex == answer1 && 
        second.startIndex == answer2 &&
        third.startIndex == answer3 &&
        forth.startIndex == answer4)
        {
            gameObject.SetActive(false);
            _AfterAnswer.SetActive(true);
            _Room_d.Panel_to_CloseUp[1] = _AfterAnswer;
            FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
            FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(0.15f, 2f);
            

        }
    }


}
