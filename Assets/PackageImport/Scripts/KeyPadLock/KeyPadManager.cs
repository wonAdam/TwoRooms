using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadManager : MonoBehaviour
{
    [SerializeField] string answer;
    public string buffer = "";

    public void GetInput(int num)
    {
        buffer += num.ToString();

        if (buffer.Length >= 4)
        {
            IsCorrect(buffer);
        }

    }
    
    private void IsCorrect(string param)
    {
        if(param == answer)
        {
            //do something
            Debug.Log("Correct");
            buffer = "";
        }
        else
        {
            //do something
            Debug.Log("Wrong");
            buffer = "";
        }
    }

}
