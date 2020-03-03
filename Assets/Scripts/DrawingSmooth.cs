using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DrawingSmooth : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{

    public Memo_Mgr memo_mgr_script;
    public Vector3 startPenPosition;
    public Vector3 endPenPosition;
    public Vector3 touchPos;
    public int smoothness;


    // Start is called before the first frame update
    void Start()
    {
        memo_mgr_script = FindObjectOfType<Memo_Mgr>();
    }

    void Update()
    {
        // if(memo_mgr_script.selectedDotColor != null)
        // {
        //     if (Input.GetMouseButton(0))
        //     {
        //         touchPos = new Vector3(
        //             Camera.main.ScreenToWorldPoint(Input.mousePosition).x,
        //             Camera.main.ScreenToWorldPoint(Input.mousePosition).y,
        //             0f);
        //         if(memo_mgr_script.selectedDotColor != null)
        //             Instantiate(memo_mgr_script.selectedDotColor, touchPos, Quaternion.identity, memo_mgr_script.memoPaper.transform);
        //     }
        //     if (Input.touchCount > 0)
        //     {
        //         touchPos = new Vector3(
        //             Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).x,
        //             Camera.main.ScreenToWorldPoint(Input.GetTouch(0).position).y,
        //             0f);
        //         if(memo_mgr_script.selectedDotColor != null)
        //             Instantiate(memo_mgr_script.selectedDotColor, touchPos, Quaternion.identity, memo_mgr_script.memoPaper.transform);
        //     }
        // }
    }

    void IBeginDragHandler.OnBeginDrag(PointerEventData eventData)
    {
        
        Vector3 tmp = Camera.main.ScreenToWorldPoint(eventData.position);
        startPenPosition = new Vector3(tmp.x, tmp.y, 0f);
        if(memo_mgr_script.selectedDotColor != null)
            Instantiate(memo_mgr_script.selectedDotColor, startPenPosition, Quaternion.identity, memo_mgr_script.memoPaper.transform);

    }

    void IDragHandler.OnDrag(PointerEventData eventData)
    {
        Vector3 tmp = Camera.main.ScreenToWorldPoint(eventData.position);
        endPenPosition = new Vector3(tmp.x, tmp.y, 0f);
        /* Let's start math... */

        if (memo_mgr_script.selectedDotColor != null)
        {
            float x_ratio = (endPenPosition.x - startPenPosition.x) / smoothness;
            float y_ratio = (endPenPosition.y - startPenPosition.y) / smoothness;
            for (int i = 1; i <= smoothness; i++)
            {
                Vector3 objPosition = new Vector3(startPenPosition.x + (x_ratio * i), startPenPosition.y + (y_ratio * i), 10f);
                Instantiate(memo_mgr_script.selectedDotColor, objPosition, Quaternion.identity, memo_mgr_script.memoPaper.transform);
            }

            startPenPosition = Camera.main.ScreenToWorldPoint(eventData.position);
        }
    }

    void IEndDragHandler.OnEndDrag(PointerEventData eventData){

    }

}
