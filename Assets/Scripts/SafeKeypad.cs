using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeKeypad : MonoBehaviour
{
    [SerializeField] A_3_Answer a_3_Answer;
    [SerializeField] int btn_num;
    public SFXManager SFXManager;
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }
    public void OnClick_SafeKeypad()
    {
        SFXManager.PlaySFX(SFXManager.KeypadClick);
        a_3_Answer.buffer += btn_num.ToString();
        a_3_Answer.CheckIfIsAnswer();
    }


}
