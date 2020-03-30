using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundMoveTrigger : MonoBehaviour
{
    [SerializeField] Animator moveingBackground;
    public void TriggerMoveBG()
    {
        moveingBackground.SetTrigger("FloatingStart");
    }
}
