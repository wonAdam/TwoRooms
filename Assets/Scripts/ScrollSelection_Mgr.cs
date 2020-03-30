using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollSelection_Mgr : MonoBehaviour
{
    [SerializeField] Sprite[] ImageArr;
    [SerializeField] B_3_Answer b_3_Answer = null;
    [SerializeField] public int imgIndex = 0;

    public SFXManager SFXManager;
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }

    public void memoClickImageSwap()
    {
        if (gameObject.CompareTag("9x9Changable"))
        {
            SFXManager.PlaySFX(SFXManager.Marker);
            if (imgIndex >= ImageArr.Length - 1)
            {
                imgIndex = 0;
            }
            else
            {
                ++imgIndex;
            }
            
            gameObject.GetComponent<Image>().sprite = ImageArr[imgIndex];

            if(b_3_Answer != null)
                b_3_Answer.CheckIfIsAnswer();
        }
    }
}
