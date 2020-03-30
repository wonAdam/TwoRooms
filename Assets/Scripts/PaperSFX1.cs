using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaperSFX1 : MonoBehaviour
{
    [SerializeField] SFXManager SFXManager;
    void OnEnable()
    {
        SFXManager.PlaySFX(SFXManager.PaperFlip2);
    }
    void OnDisable()
    {
        SFXManager.PlaySFX(SFXManager.PaperFlip2);
    }}
