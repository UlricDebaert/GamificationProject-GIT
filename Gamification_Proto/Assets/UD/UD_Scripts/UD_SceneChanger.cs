using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UD_SceneChanger : MonoBehaviour
{
    public string sceneNameToChangeOnPress;

    public void ChangeScene()
    {
        SceneManager.LoadScene(sceneNameToChangeOnPress);
    }
}
