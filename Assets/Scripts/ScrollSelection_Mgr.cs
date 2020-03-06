using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollSelection_Mgr : MonoBehaviour
{
    [SerializeField] Sprite[] ImageArr;
    [SerializeField] B_3_Answer b_3_Answer = null;
    [SerializeField] public int imgIndex = 0;

    //private void Update()
    //{
    //    if (Input.GetMouseButton(0))
    //    {
    //        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
    //        RaycastHit hit;
    //        Debug.Log("Mouse Clicked");
    //        if(Physics.Raycast(ray, out hit))
    //        {
    //            var selection = hit.transform;
    //            var selectionImage = selection.GetComponent<Image>();
    //            Debug.Log(selection);

    //            if (selection.CompareTag("9x9Changable"))
    //            {
    //                if (imgIndex >= ImageArr.Length - 1)
    //                {
    //                    imgIndex = 0;
    //                }
    //                else
    //                {
    //                    ++imgIndex;
    //                }
    //                selectionImage = ImageArr[imgIndex];
    //            }
    //        }

    //    }
    //}

    public void memoClickImageSwap()
    {
        if (gameObject.CompareTag("9x9Changable"))
        {
            if (imgIndex >= ImageArr.Length - 1)
            {
                imgIndex = 0;
            }
            else
            {
                ++imgIndex;
            }
            
            gameObject.GetComponent<Image>().sprite = ImageArr[imgIndex];

            if(b_3_Answer != null)
                b_3_Answer.CheckIfIsAnswer();
        }
    }
}
