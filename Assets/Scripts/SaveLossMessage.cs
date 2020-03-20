using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class SaveLossMessage : MonoBehaviour
{

    [SerializeField] MenuManager menuManager;


    public void OpenWindow()
    {
        gameObject.transform.DOScale(new Vector3(1f,1f,1f), 0.3f);
    }
    public void OnClick_Yes()
    {
        PlayerPrefs.DeleteAll();
        UnityEngine.SceneManagement.SceneManager.LoadScene("DescriptionScene");
    }

    public void OnClick_No()
    {
        gameObject.transform.DOScale(new Vector3(0f,0f,1f), 0.3f);
    }
}
