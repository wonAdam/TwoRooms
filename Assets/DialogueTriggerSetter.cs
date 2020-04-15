using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogueTriggerSetter : MonoBehaviour
{
    
    void OnEnable()
    {
        Resources.FindObjectsOfTypeAll<Dialogue>()[0].afterDialogueTrigger = 
            GetComponent<TutorRoomPanel>().partnerTutorPanel.GetComponent<Animator>();
    }

}
