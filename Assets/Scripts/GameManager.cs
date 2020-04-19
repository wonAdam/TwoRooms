using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public float volume = 0.4f;
    [SerializeField] Slider volumeSlider;

    public void OnChangeVolume()
    {
        volume = volumeSlider.value;
    }   
}
