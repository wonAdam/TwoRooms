using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TutorialManager : MonoBehaviour
{
    [Header("Set Your Own")]
    [SerializeField] TutorNPanel[] tutorialNPanels;
    [SerializeField] TutorRoomPanel[] tutorialRoomPanels;
    [SerializeField] List<Collider> colliders;

    [Header("Automatic")]
    public List<Collider> collidersToInactive;
    public Button[] buttons;
    public bool isTutorialing = false;
    [SerializeField] GameObject[] B_Room_BugFix;


    void Start()
    {

        foreach(Collider collider in colliders)
        {
            if(collider.gameObject.activeSelf == true)
            {
                collidersToInactive.Add(collider);
            }
        }

        buttons = FindObjectsOfType<Button>();

    }

    public void StartOfTutorial()
    {
        isTutorialing = true;
        ColliderInactivate();
        BtnInactivate();
    }

    public void ColliderInactivate()
    {
        foreach(Collider collider in collidersToInactive)
        {
            collider.gameObject.SetActive(false);
        }
    }

    public void ColliderActivate()
    {
        foreach(Collider collider in collidersToInactive)
        {
            collider.gameObject.SetActive(true);
        }
    }

    public void BtnInactivate()
    {
        foreach(Button b in buttons)
        {
            b.interactable = false;
        }
    }

    public void BtnActivate()
    {
        foreach(Button b in buttons)
        {
            b.interactable = true;
        }
    }

    public void ResetForTutorPenel()
    {
        foreach(TutorNPanel tnp in Resources.FindObjectsOfTypeAll<TutorNPanel>())
        {
            tnp.gameObject.SetActive(false);
        }
    }

    public void EndTheTutorial()
    {
        Debug.Log("TutorialManager - EndTheTutorial");

        BtnActivate();
        ColliderActivate();
        if(B_Room_BugFix.Length > 0)
        {
            foreach(GameObject go in B_Room_BugFix)
            {
                go.SetActive(true);
            }
            Resources.FindObjectsOfTypeAll<RoomB_BugFixScript>()[0].tutorialOver = true;
        }
    }
}
