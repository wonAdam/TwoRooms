using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TutorRoomPanel : MonoBehaviour
{
    [Header ("Set Your Own")]
    [SerializeField] Button[] buttonsToBeActive;
    [SerializeField] Collider[] collidersToBeActive;
    [SerializeField] public GameObject partnerTutorPanel;
    [TextArea][SerializeField] List<string> speaker;
    [TextArea][SerializeField] List<string> content;

    [SerializeField] Collider[] activeAtEnd;

    [Header ("Automatic")]
    public bool isFirstTime = true;


    public void SetForThisTutor()
    {
        // ui reset
        FindObjectOfType<TutorialManager>().ColliderInactivate();
        FindObjectOfType<TutorialManager>().BtnInactivate();

        // ui set for this scene
        SetColsNBtns();
        FindObjectOfType<TutorialManager>().ResetForTutorPenel();
        partnerTutorPanel.SetActive(true);


        // dialogue set if isFirstTime
        if(isFirstTime == true)
        {
            isFirstTime = false;
            if(speaker.Count > 0)
            {
                List<KeyValuePair<string, string>> param = new List<KeyValuePair<string, string>>();
                for(int i = 0 ; i < speaker.Count; i++)
                {
                    param.Add(new KeyValuePair<string, string>(
                        speaker[i], 
                        content[i])
                        );
                }
                Resources.FindObjectsOfTypeAll<Dialogue>()[0].gameObject.SetActive(true);
                Resources.FindObjectsOfTypeAll<Dialogue>()[0].StartDialogue(param);
            }
        }


    }

    void SetColsNBtns()
    {
        foreach(Collider collider in collidersToBeActive)
        {
            collider.gameObject.SetActive(true);
        }
        foreach(Button btn in buttonsToBeActive)
        {
            btn.interactable = true;
        }
    }



}
