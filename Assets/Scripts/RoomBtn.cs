using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RoomBtn : MonoBehaviour
{

    [SerializeField] string nextSceneName;
    public void OnPointEnter()
    {
        gameObject.transform.localScale = new Vector3(1.2f,1.2f,1f);
    }

    public void OnPointExit()
    {
        gameObject.transform.localScale = new Vector3(1f,1f,1f);
    }

    public void OnPointUp()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(nextSceneName);
    }
}
