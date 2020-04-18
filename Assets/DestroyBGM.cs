using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class DestroyBGM : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        FindObjectOfType<DescriptionBGM>().GetComponent<AudioSource>().DOFade(0f, 4f);
        Screen.SetResolution(1920,1080,FullScreenMode.FullScreenWindow);
        Invoke("DestroyBGMFunc", 4f);
    }

    private void DestroyBGMFunc()
    {
        Destroy(FindObjectOfType<DescriptionBGM>().gameObject);
    }
}
