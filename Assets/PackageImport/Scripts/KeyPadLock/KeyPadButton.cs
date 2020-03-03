using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPadButton : MonoBehaviour
{
    [SerializeField] int num;
    [SerializeField] KeyPadManager KeyPadMgr;

    public void OnClick_KeyPadButton()
    {
        KeyPadMgr.GetInput(num);
    }
}
