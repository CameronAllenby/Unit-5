using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Leavegame : MonoBehaviour
{
    public string sceneName;

    public void ChangeScene()
    {
        print("loading scene " + sceneName);
        SceneManager.LoadScene(sceneName);
    }
}
