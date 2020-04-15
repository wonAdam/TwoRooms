using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class B_Bed : MonoBehaviour
{
    [SerializeField] SceneManager sceneManager;
    [SerializeField] GameObject OpenedPanel;
    [SerializeField] GameObject BedClosed;
    [SerializeField] int BedPanelIndex;

    SFXManager SFXManager;
    [SerializeField] bool isPutScene;
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }

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
                        if(isPutScene)
                            SFXManager.PlaySFX(SFXManager.BlanketFluff);
                        else
                            SFXManager.PlaySFX(SFXManager.BlanketPut);
                            
                        sceneManager.RoomPanel[BedPanelIndex] = OpenedPanel;
                        gameObject.SetActive(false);
                        OpenedPanel.SetActive(true);
                    }

                }


            }
        }

        else if(Input.GetMouseButtonDown(0))
        {
                Debug.Log("Touch Detected");
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
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
