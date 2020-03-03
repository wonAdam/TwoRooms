using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Number : MonoBehaviour
{
    [SerializeField] public int startIndex;
    [SerializeField] Sprite[] spriteArray;
    [SerializeField] A_2_Answer a_2_Answer = null;

    private void Start()
    {
       gameObject.GetComponent<Image>().sprite = spriteArray[startIndex];
    }

    public void NumInc()
    {
        
            if (startIndex == spriteArray.Length - 1)
                startIndex = 0;
            else
                startIndex++;

            GetComponent<Image>().sprite = spriteArray[startIndex];

            if(a_2_Answer)
            {
                a_2_Answer.IsItAnswer();
            }

            return;
        
    }
    public void NumDec()
    {

            if (startIndex == 0)
                startIndex = spriteArray.Length - 1;
            else
                startIndex--;

            GetComponent<Image>().sprite = spriteArray[startIndex];

            if(a_2_Answer)
            {
                a_2_Answer.IsItAnswer();
            }

            return;
        
    }


}