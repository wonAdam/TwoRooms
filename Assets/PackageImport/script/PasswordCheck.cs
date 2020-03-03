using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using UnityEngine.SceneManagement;

public class PasswordCheck : MonoBehaviour
{
    private string password = "12345";
    public InputField UserInput;
    public string USERINPUT;
    // private string correct = "Scene/correct";
    // private string wrong = "Scene/wrong";


    public void CheckPassword ()
    {
        USERINPUT = UserInput.text;

        if (USERINPUT != null)
        {
            if (USERINPUT == password)
            {
                Debug.Log("correct");
            }
            else
            {
                Debug.Log("wrong");
            }
        }
    }
}