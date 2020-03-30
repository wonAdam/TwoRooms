﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BookSound : MonoBehaviour
{
    [SerializeField] SFXManager SFXManager;

    void OnEnable()
    {
        SFXManager.PlaySFX(SFXManager.BookOpen);
    }

    void OnDisable()
    {
        SFXManager.PlaySFX(SFXManager.BookClose);
    }
}
