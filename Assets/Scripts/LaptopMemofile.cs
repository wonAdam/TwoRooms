using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class LaptopMemofile : MonoBehaviour
{
    [SerializeField] GameObject MemoWindow;
    [SerializeField] public GameObject ClickedMark;
    public Vector3 init_pos;
    public bool isOpened = false;

    void Start()
    {
        init_pos = MemoWindow.transform.position;
        MemoWindow.transform.localScale = new Vector3(0f,0f,0f);
        ClickedMark.SetActive(false);
    }

    public void MemoOpen()
    {
        if(isOpened == false){
            isOpened = true;
            ClickedMark.SetActive(true);
            MemoWindow.transform.DOScale(new Vector3(1f,1f,1f), 0.3f);
            MemoWindow.transform.DOMove(new Vector3(0f,0f,0f), 0.3f);
        }
    }
}
