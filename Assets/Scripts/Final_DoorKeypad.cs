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

    public void OnClick_Keypad(int num)
    {
        buffer += num.ToString();
        if(buffer.Length >= 4)
        {
            if(buffer == answer)
            {
                StartCoroutine(LoadToEnding());
            }
            buffer = "";
        }
    }

    IEnumerator LoadToEnding()
    {
        FadeInOut.SetActive(true);
        FadeInOut.GetComponent<Image>().DOFade(1f, 2f);
        yield return new WaitForSeconds(2f);
        UnityEngine.SceneManagement.SceneManager.LoadScene("Ending");
    }
}
