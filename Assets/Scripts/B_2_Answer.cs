using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_2_Answer : MonoBehaviour
{
    [SerializeField] LaptopPwdPanel laptopPwdPanel;
    [SerializeField] string[] answers;
    [SerializeField] CloseUp laptopSidePanel;
    [SerializeField] GameObject afterAnswerLaptop;


    //[SerializeField] GameObject _AfterAnswer;
    //[SerializeField] CloseUp _Room_c;

    public void CheckAnswer(string input){
        foreach(string answer in answers)
        {

            if(input == answer)
            {
                Debug.Log("Correct");
                laptopSidePanel.Panel_to_CloseUp[0] = afterAnswerLaptop;
                afterAnswerLaptop.SetActive(true);
                gameObject.SetActive(false);
                laptopSidePanel.gameObject.SetActive(false);
                return;
            }

        }

        Debug.Log("Wrong");

    }
}
