using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;


public class servePlate : MonoBehaviour
{
    [SerializeField] private bool rightMeal = false;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && (Input.GetKeyDown(KeyCode.J)||InputBridge.Instance.BButtonDown))
        {
            Debug.Log("plateValue = " + GameFlow.plateValue);
            Debug.Log("orderValue = " + GameFlow.orderValue);
            if(GameFlow.plateValue == GameFlow.orderValue)
            {
                rightMeal = true;
                PixelCrushers.MessageSystem.SendMessage(this,"Got","Sandwich");
            }else
            {
                PixelCrushers.MessageSystem.SendMessage(this,"Got","FakeSandwich");
            }

        }
        
    }
}
