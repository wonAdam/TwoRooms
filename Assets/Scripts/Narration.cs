using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using DG.Tweening;

public class Narration : MonoBehaviour
{
    [SerializeField] Text narrationText;

    public void NarrationTextIn(string message)
    {   
        narrationText.text = message;
    }
}
