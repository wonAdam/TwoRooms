using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrinceBoxOpen : MonoBehaviour
{
    [SerializeField] SFXManager SFXManager;

    void OnEnable()
    {
        SFXManager.PlaySFX(SFXManager.PrinceBoxOpen);
    }

    void OnDisable()
    {
        SFXManager.PlaySFX(SFXManager.BookClose);
    }
}
