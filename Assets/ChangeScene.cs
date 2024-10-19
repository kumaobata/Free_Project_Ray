using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public string[] SceneNames;

    public void ChangeSceneToNum(int num)
    {
        SceneManager.LoadScene(SceneNames[num]);
    }
}