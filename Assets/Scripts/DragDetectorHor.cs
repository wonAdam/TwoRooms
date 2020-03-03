using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDetectorHor : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] GameObject[] SameRowImage;
    //[SerializeField] B_1_Answer b_1_Answer;

    public float startXPos;
    public float endXPos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startXPos = eventData.position.x;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        endXPos = eventData.position.x;

        //Drag  Left ->  Number needs to be increased
        if(startXPos - endXPos > 0)
        {
            foreach (GameObject img in SameRowImage)
            {
                img.GetComponent<Number>().NumInc();
            }

            //b_1_Answer.CheckAnswer();
            
            return;
        }
        if (startXPos - endXPos < 0)
        {
            foreach (GameObject img in SameRowImage)
            {
                img.GetComponent<Number>().NumDec();
            }

            //b_1_Answer.CheckAnswer();

            return;
        }


    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
