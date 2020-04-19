using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialEnable : MonoBehaviour
{
    void OnEnable()
    {
        GetComponent<TutorRoomPanel>().SetForThisTutor();
    }
}
