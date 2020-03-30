using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DigitalClock : MonoBehaviour
{

    [SerializeField] Sprite[] Nums;
    [SerializeField] A_1_Answer a_1_Answer;
    [SerializeField] GameObject[] Times;
    [SerializeField] public int hourTenStartNumIndex = 0;
    [SerializeField] public int hourOneStartNumIndex = 0;
    [SerializeField] public int minTenStartNumIndex = 0;
    [SerializeField] public int minOneStartNumIndex = 0;


    void Start()
    {
        Times[0].GetComponent<Image>().sprite = Nums[hourTenStartNumIndex];
        Times[1].GetComponent<Image>().sprite = Nums[hourOneStartNumIndex];
        Times[2].GetComponent<Image>().sprite = Nums[minTenStartNumIndex];
        Times[3].GetComponent<Image>().sprite = Nums[minOneStartNumIndex];
    }

    public void OnClick_HourTen()
    {
        if(hourTenStartNumIndex == 1)
        {
            hourTenStartNumIndex = 0;
            Times[0].GetComponent<Image>().sprite = Nums[hourTenStartNumIndex];
        }
        else
        {
            hourTenStartNumIndex = 1;
            Times[0].GetComponent<Image>().sprite = Nums[hourTenStartNumIndex];
        }

        a_1_Answer.CheckAnswerTrigger();
    }

    public void OnClick_HourOne()
    {
        if(hourOneStartNumIndex == 9)
        {
            hourOneStartNumIndex = 0;
            Times[1].GetComponent<Image>().sprite = Nums[hourOneStartNumIndex];
        }
        else
        {
            hourOneStartNumIndex++;
            Times[1].GetComponent<Image>().sprite = Nums[hourOneStartNumIndex];
        }

        a_1_Answer.CheckAnswerTrigger();
    }

    public void OnClick_MinTen()
    {
        if(minTenStartNumIndex == 5)
        {
            minTenStartNumIndex = 0;
            Times[2].GetComponent<Image>().sprite = Nums[minTenStartNumIndex];
        }
        else
        {
            minTenStartNumIndex++;
            Times[2].GetComponent<Image>().sprite = Nums[minTenStartNumIndex];
        }

        a_1_Answer.CheckAnswerTrigger();
    }

    public void OnClick_MinOne()
    {
        if(minOneStartNumIndex == 9)
        {
            minOneStartNumIndex = 0;
            Times[3].GetComponent<Image>().sprite = Nums[minOneStartNumIndex];
        }
        else
        {
            minOneStartNumIndex++;
            Times[3].GetComponent<Image>().sprite = Nums[minOneStartNumIndex];
        }

        a_1_Answer.CheckAnswerTrigger();
    }
}
