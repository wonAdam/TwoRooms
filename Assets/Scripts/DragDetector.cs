using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class DragDetector : MonoBehaviour, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] GameObject[] SameColImage;
    [SerializeField] B_1_Answer b_1_Answer;

    public float startYPos;
    public float endYPos;

    public void OnBeginDrag(PointerEventData eventData)
    {
        startYPos = eventData.position.y;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        endYPos = eventData.position.y;

        //Drag  Down ->  Number needs to be increased
        if(startYPos - endYPos > 0)
        {
            foreach (GameObject img in SameColImage)
            {
                img.GetComponent<Number>().NumInc();
            }

            b_1_Answer.CheckAnswer();
            
            return;
        }
        if (startYPos - endYPos < 0)
        {
            foreach (GameObject img in SameColImage)
            {
                img.GetComponent<Number>().NumDec();
            }

            b_1_Answer.CheckAnswer();

            return;
        }


    }

    public void OnDrag(PointerEventData eventData)
    {

    }
}
