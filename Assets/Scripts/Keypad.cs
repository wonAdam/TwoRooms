using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Keypad : MonoBehaviour
{
    [SerializeField] Button[] KeypadBtn;
    [SerializeField] string Answer;
    [SerializeField] int lengthOfAnswer = 4;

    public string Buffer = "";
    public int BufferLength = 0;

    public void OnClick_Btn(int num)
    {
        Buffer += num.ToString();
        if(Buffer.Length >= lengthOfAnswer)
        {           
            isCorrect();
        }
    }

    private bool isCorrect()
    {
        if(Buffer == Answer)
        {
            Debug.Log("Correct");
            Buffer = "";
            return true;
        }
        else
        {
            Debug.Log("Wrong");
            Buffer = "";
            return false;
        }
    }
}
