using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenNextBook : MonoBehaviour
{
    [SerializeField] GameObject[] nextBook;
    [SerializeField] public int indexOfThisBook;
    public bool isClicked = false;

    public void OpenNextBookFunc()
    {
        if(isClicked == true) { return; }
        if(nextBook == null) { isClicked = true; return;}

        foreach(GameObject GO in nextBook)
        {
            GO.SetActive(true);
        }
        isClicked = true;

        FindObjectOfType<SaveManager>().Save(
            FindObjectOfType<SaveManager>().Load().Room, 
            FindObjectOfType<SaveManager>().Load().level, 
            indexOfThisBook,
            FindObjectOfType<SaveManager>().Load().interview);
    }
}
