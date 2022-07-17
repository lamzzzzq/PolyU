using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using PixelCrushers.DialogueSystem;

public class ChangeScene : MonoBehaviour
{
    public void MoveToScene(string scene)
    {
        Debug.Log("Clicked to MoveScene");

        PixelCrushers.SaveSystem.LoadScene(scene);
        //SceneManager.LoadScene(sceneID);
    }
}
