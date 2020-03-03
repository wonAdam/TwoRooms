using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollOpen : MonoBehaviour
{
    [SerializeField] GameObject scrollOpened;

    
    private void Start()
    {
        scrollOpened.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetMouseButton(0))
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit))
            {
                var selection = hit.transform;
                if (selection.gameObject == gameObject)
                {
                    S_Clicked();
                }
            }
        }
    }

    public void S_Clicked()
    {
        scrollOpened.SetActive(true);
    }

}
