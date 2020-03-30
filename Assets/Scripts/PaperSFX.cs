using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSFX : MonoBehaviour
{
    [SerializeField] SFXManager SFXManager;
    void OnEnable()
    {
        SFXManager.PlaySFX(SFXManager.PaperFlip1);
    }
    void OnDisable()
    {
        SFXManager.PlaySFX(SFXManager.PaperFlip1);
    }
}
