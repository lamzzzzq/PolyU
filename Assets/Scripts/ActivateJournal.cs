using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class ActivateJournal : MonoBehaviour
{

    [SerializeField] private GameObject hud;


    void Update()
    {
        //
        //if(InputBridge.Instance.AButtonDown)
        if(Input.GetKeyDown(KeyCode.M))
        {
            PixelCrushers.QuestMachine.QuestMachine.GetQuestJournal().ToggleJournalUI();
            Debug.Log("V");
        }

    }
}
