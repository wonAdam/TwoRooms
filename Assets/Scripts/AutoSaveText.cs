using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class AutoSaveText : MonoBehaviour
{
    [SerializeField] float gapBtwnDots = 0.35f;
    [SerializeField] GameObject autoSaveUI;
    public Text thisText;
    public string defualtStr;
    
    void Start()
    {

    }
    void OnEnable()
    {
        thisText = GetComponent<Text>();
        defualtStr = thisText.text;
        thisText.text = defualtStr;
        StartCoroutine(dotdotdot());
        Invoke("DisableThis", 3f);
    }

    IEnumerator dotdotdot()
    {
        while(true)
        {
            thisText.text += " . ";
            yield return new WaitForSeconds(gapBtwnDots);
            thisText.text += " . ";
            yield return new WaitForSeconds(gapBtwnDots);
            thisText.text += " . ";
            yield return new WaitForSeconds(gapBtwnDots);
            thisText.text = defualtStr;
            yield return new WaitForSeconds(gapBtwnDots);        
        }
    }


    void OnDisable()
    {
        StopAllCoroutines();
        defualtStr = thisText.text;
    }

    


}
