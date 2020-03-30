using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopOpen : MonoBehaviour
{
    [SerializeField] SFXManager SFXManager;

    void OnEnable()
    {
        SFXManager.PlaySFX(SFXManager.TurnOn);
    }

}
