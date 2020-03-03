using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookDrag : MonoBehaviour
{
    public float startMousePos = 0f;
    public float endMousePos = 0f;

    [SerializeField] float maxYPos;
    [SerializeField] float minYPos;

    public float debuging_newYPos = 0;


    void OnMouseDown()
    {

        startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;
    
    }
    
    void OnMouseDrag()
    {
        endMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

        float offset = endMousePos - startMousePos;

        float newYPos = Mathf.Clamp(transform.position.y + offset, minYPos, maxYPos);

        debuging_newYPos = newYPos;

        transform.position = new Vector3(transform.position.x, newYPos, transform.position.z);

        startMousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition).y;

    }

}
