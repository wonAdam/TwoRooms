using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RoomBtn : MonoBehaviour
{

    [SerializeField] string nextSceneName;
    public Vector2 StartPos;
    public Sprite closedSprite;

    [SerializeField] Vector2 FixPos;
    [SerializeField] Vector2 FixScale;

    [SerializeField] Sprite Opened;
    [SerializeField] GameObject door;

    public SFXManager SFXManager;
    void Start()
    {
        StartPos = door.GetComponent<RectTransform>().anchoredPosition;
        closedSprite = door.GetComponent<Image>().sprite;
        SFXManager = FindObjectOfType<SFXManager>();
    }
    public void OnPointEnter(GameObject Door)
    {
        Door.GetComponent<RectTransform>().anchoredPosition = FixPos;
        Door.GetComponent<RectTransform>().localScale = FixScale;
        Door.GetComponent<Image>().sprite = Opened;    
        SFXManager.PlaySFX(SFXManager.DoorOpen);
    }

    public void OnPointExit(GameObject Door)
    {
        Door.GetComponent<RectTransform>().localScale = new Vector3(1f,1f,1f);
        Door.GetComponent<RectTransform>().anchoredPosition = StartPos;
        Door.GetComponent<Image>().sprite = closedSprite;    
    }

    public void OnPointUp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }
}
