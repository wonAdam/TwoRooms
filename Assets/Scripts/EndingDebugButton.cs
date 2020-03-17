using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingDebugButton : MonoBehaviour
{
    public void OnClick_ToPastRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("A_Room_Scene");
    }
    public void OnClick_ToFutureRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("B_Room_Scene");
    }
}
