using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSound : MonoBehaviour
{
    [SerializeField] SFXManager SFXManager;

    void OnEnable()
    {
        SFXManager.PlaySFX(SFXManager.BoxScratch);
    }

    void OnDisable()
    {
        SFXManager.PlaySFX(SFXManager.BoxScratch);
    }
}
