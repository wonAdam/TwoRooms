using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnder : MonoBehaviour
{
    public void EndTutorial()
    {
        Debug.Log("TutorialEnder - EndTutorial");
        Resources.FindObjectsOfTypeAll<TutorialManager>()[0].EndTheTutorial();

        foreach(TutorialEnable go in Resources.FindObjectsOfTypeAll<TutorialEnable>())
        {
            go.enabled = false;
        }
        foreach(TutorRoomPanel go in Resources.FindObjectsOfTypeAll<TutorRoomPanel>())
        {
            go.enabled = false;
        }        

    }
}
