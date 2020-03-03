using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;


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


    public void CheckAnswer(){
        if(digitalClock.hourTenStartNumIndex == answer1 && 
        digitalClock.hourOneStartNumIndex == answer2 &&
        digitalClock.minTenStartNumIndex == answer3 &&
        digitalClock.minOneStartNumIndex == answer4)
        {
            FindObjectOfType<GameManager>().GetComponent<AudioSource>().UnPause();
            FindObjectOfType<GameManager>().GetComponent<AudioSource>().DOFade(0.15f, 2f);
            _AfterAnswer.SetActive(true);
            for(int i = 0 ; i < englishPoemTouch.Length; i++)
            {
                englishPoemTouch[i].SetActive(true);
            }

            _Room_c.Panel_to_CloseUp[1] = _AfterAnswer;
            for(int i = 0; i < _DestroyAfter.Length; i++)
            {

                _DestroyAfter[i].SetActive(false);

            }

        }
    }
}
