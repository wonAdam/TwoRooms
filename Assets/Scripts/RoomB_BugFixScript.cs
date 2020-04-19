using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomB_BugFixScript : MonoBehaviour
{
    public bool tutorialOver = false;
    [SerializeField] GameObject[] activateThese;
    void OnEnable()
    {
        if(tutorialOver == true)
        {
            foreach(GameObject go in activateThese)
            {
                go.SetActive(true);
            }
            GetComponent<CloseUp>().enabled = true;

            tutorialOver = false;
        }
    }
}
