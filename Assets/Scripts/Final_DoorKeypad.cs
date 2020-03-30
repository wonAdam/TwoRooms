using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using DG.Tweening;

public class Final_DoorKeypad : MonoBehaviour
{
    [SerializeField] string answer = "0928";
    [SerializeField] GameObject FadeInOut;
    [SerializeField] AudioClip doorOpenSound;
    public string buffer = "";
    public SFXManager SFXManager;
    
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }

    public void OnClick_Keypad(int num)
    {
        buffer += num.ToString();
        if(buffer.Length >= 4)
        {           
            if(buffer == answer)
            {
                SFXManager.PlaySFX(SFXManager.KeypadPass);
                StartCoroutine(LoadToEnding());
            }
            else
            {
                SFXManager.PlaySFX(SFXManager.KeypadWrong);
            }
            buffer = "";
        }
        else
        {
            SFXManager.PlaySFX(SFXManager.KeypadClick);
        }
    }

    IEnumerator LoadToEnding()
    {

        FindObjectOfType<SaveManager>().DeleteSaveData();

        FadeInOut.SetActive(true);
        FadeInOut.GetComponent<Image>().DOFade(1f, 2f);
        yield return new WaitForSeconds(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Ending");
    }
}
