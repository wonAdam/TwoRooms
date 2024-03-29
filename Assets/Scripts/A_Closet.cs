﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class A_Closet : MonoBehaviour
{
    [SerializeField] SceneManager sceneManager;
    [SerializeField] GameObject OpenedPanel;
    [SerializeField] GameObject ClosetClosed;
    [SerializeField] int ClosetPanelIndex;
    [SerializeField] bool isOpened;
    public SFXManager SFXManager;
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
                    if(hit.collider.name == ClosetClosed.name){
                        if(isOpened)
                            SFXManager.PlaySFX(SFXManager.ClosetOpen);
                        else
                            SFXManager.PlaySFX(SFXManager.ClosetClose);

                        sceneManager.RoomPanel[ClosetPanelIndex] = OpenedPanel;
                        gameObject.SetActive(false);
                        OpenedPanel.SetActive(true);
                    }

                }


            }
        }
    }


}
