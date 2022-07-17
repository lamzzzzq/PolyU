using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class MeatSlice : MonoBehaviour
{
    //public GameObject meatBaking;
    public GameObject toInstantiate;

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(gameObject.name == "LunchMeat" && (Input.GetKeyDown(KeyCode.J)||InputBridge.Instance.BButtonDown))
            {
                //meatBaking.SetActive(true);
                Instantiate(toInstantiate);

                Debug.Log("Move LunchMeatSlice");
            }
        }
    }
}
