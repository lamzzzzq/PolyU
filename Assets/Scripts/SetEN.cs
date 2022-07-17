using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.UI;

public class SetEN : MonoBehaviour
{
    // test 1
    void Start()
    {
        Button btn = this.GetComponent<Button>();
        btn.onClick.AddListener(OnClick);
    }
    private void OnClick()
    {
        DialogueManager.SetLanguage("en");
        Debug.Log("Set-en");
    }
}
