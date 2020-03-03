using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Bed : MonoBehaviour
{
    [SerializeField] SceneManager sceneManager;
    [SerializeField] GameObject OpenedPanel;
    [SerializeField] GameObject BedClosed;
    [SerializeField] int BedPanelIndex;


    void Update()
    {
        OnTouchDetected();
    }


    private void OnTouchDetected()
    {

        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {

                Debug.Log("Touch Detected");
                Ray ray = Camera.main.ScreenPointToRay(Input.GetTouch(0).position);
                RaycastHit hit;

                if(Physics.Raycast(ray, out hit))
                {
                    if(hit.collider.name == BedClosed.name){
                        sceneManager.RoomPanel[BedPanelIndex] = OpenedPanel;
                        gameObject.SetActive(false);
                        OpenedPanel.SetActive(true);
                    }

                }


            }
        }
    }


}
