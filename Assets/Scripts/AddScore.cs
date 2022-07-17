using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PixelCrushers.DialogueSystem;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{

    public Text Point;

    void Update()
    {
        int value = DialogueLua.GetVariable("Point").asInt;

        Point.text = value.ToString();
    }
}
