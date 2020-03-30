using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawerOpen : MonoBehaviour
{
    [SerializeField] SFXManager SFXManager;
    [SerializeField] GameObject[] notthistime;
    void OnEnable()
    {
        foreach(GameObject tmp in notthistime)
        {
            if(tmp.activeInHierarchy == true) return;
        }
        SFXManager.PlaySFX(SFXManager.DrawerOpen);
    }

    void OnDisable()
    {
        foreach(GameObject tmp in notthistime)
        {
            if(tmp.activeInHierarchy == true) return;
        }
        SFXManager.PlaySFX(SFXManager.DrawerOpen);
    }
}
