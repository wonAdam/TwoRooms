using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaptopPwdPanel : MonoBehaviour
{
    [SerializeField] InputField LaptopPwd_IF;
    [SerializeField] B_2_Answer b_2_Answer;


    public void OnValueChange_LaptopPwd()
    {
        if(LaptopPwd_IF.text.Length >= 4){
            b_2_Answer.CheckAnswer(LaptopPwd_IF.text);
            LaptopPwd_IF.text = "";
        }
    }

}
