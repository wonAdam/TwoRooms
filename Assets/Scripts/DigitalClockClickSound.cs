using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DigitalClockClickSound : MonoBehaviour
{

    public SFXManager SFXManager;
    void Start()
    {
        SFXManager = FindObjectOfType<SFXManager>();
    }
    public void ClickSound()
    {

        SFXManager.PlaySFX(SFXManager.DigitalClockClick);

    }
}
