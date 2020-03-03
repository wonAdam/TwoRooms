using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchRoom : MonoBehaviour
{

    [SerializeField] int targetScene;

    public void OnClick_SwitchRoom()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(targetScene);
    }

}
