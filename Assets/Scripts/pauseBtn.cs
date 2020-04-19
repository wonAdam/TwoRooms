using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class pauseBtn : MonoBehaviour
{

    [SerializeField] GameObject _FadeInOut;
    public void OnClick_Pause()
    {
        StartCoroutine(FadeInOut());
    }

    IEnumerator FadeInOut()
    {
            _FadeInOut.SetActive(true);
            _FadeInOut.GetComponent<Image>().DOFade(1f, 1f);
            yield return new WaitForSeconds(1f);
            Load();

    }

    private void Load()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("MainMenu");
    }
}
