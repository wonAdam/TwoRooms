using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class sample : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    [SerializeField] Sprite[] spriteArray;
    public int startIndex = 1;
    public int endIndex;
    public float startYPos;
    public float endYPos;

    private void Start()
    {
        endIndex = spriteArray.Length - 1;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        startYPos = eventData.position.y;
        //transform.position = eventData.position;
    }

    public void OnDrag(PointerEventData eventData)
    {
        //transform.position = eventData.position;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        endYPos = eventData.position.y;
        //transform.position = eventData.position;

        //Drag  UP -> Num Decrease
        if (startYPos - endYPos < 0)
        {
            if (startIndex == 0)
                 startIndex = spriteArray.Length - 1;
            else
                startIndex--;

            GetComponent<Image>().sprite = spriteArray[startIndex];
            return;
        }
        //Drag Down -> Num Increase
        else if(startYPos - endYPos > 0)
        {
            if (startIndex == spriteArray.Length - 1)
                 startIndex = 0;
            else
                startIndex++;

            GetComponent<Image>().sprite = spriteArray[startIndex];
            return;
        }
    }


}
