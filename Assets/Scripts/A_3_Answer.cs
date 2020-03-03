using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_3_Answer : MonoBehaviour
{
    [SerializeField] string answer;
    [SerializeField] GameObject afterAnswerPanel;
    [SerializeField] GameObject previousPanel;
    public string buffer = "";


    public void CheckIfIsAnswer()
    {
        if(buffer.Length >= 4)
        {
            if(answer == buffer)
            {
                Debug.Log("Correct");
                SetForAfterAnswer();
            }
            else
            {
                Debug.Log("Wrong");
            }
            buffer = "";
        }
    }

    private void SetForAfterAnswer()
    {
        
        previousPanel.GetComponent<CloseUp>().Panel_to_CloseUp[0] = afterAnswerPanel;
        afterAnswerPanel.SetActive(true);
        GetComponent<CloseUp>().PreviousPanel = null;
        gameObject.SetActive(false);
    }


}
