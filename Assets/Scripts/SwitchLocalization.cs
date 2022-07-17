using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using BNG;

public class SwitchLocalization : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        //
        if(Input.GetKeyDown(KeyCode.L))
        {
            DialogueManager.SetLanguage("en");
            Debug.Log("SwitchLanguage");
        }

    }
}
