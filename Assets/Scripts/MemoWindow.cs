using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class MemoWindow : MonoBehaviour
{
    [SerializeField] LaptopMemofile laptopMemofile;
    void OnMouseDown()
    {
        if(laptopMemofile.isOpened == true)
        {
            laptopMemofile.isOpened = false;
            laptopMemofile.ClickedMark.SetActive(false);
            transform.DOMove(laptopMemofile.init_pos, 0.3f);
            transform.DOScale(new Vector3(0f,0f,0f), 0.3f);
        }
    }
}
