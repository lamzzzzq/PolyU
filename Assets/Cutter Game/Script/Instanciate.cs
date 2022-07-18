using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class Instanciate : MonoBehaviour
{
    //public Transform genPoint;
    public Transform cloneObj;
    public int foodValue;
    public GameObject UIObject;

    

    // private void OnTriggerStay(Collider other)
    // {
    //     if(other.tag == "Player")
    //     {   
    //         if(Input.GetKeyDown(KeyCode.J))
    //         {
    //         Instantiate(cloneObj, new Vector3(10.95f,0.3f,26.49f), cloneObj.rotation);
    //         Debug.Log("Instantiate Burger");
    //         }
    //     }



    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            if(gameObject.name == "BreadTop" && (Input.GetKeyDown(KeyCode.J)||InputBridge.Instance.BButtonDown))
            {
                Instantiate(cloneObj, new Vector3(10.937f,0.23f,26.1f), Quaternion.identity);
                Debug.Log("Instantiate Burger Top");
                GameFlow.plateValue += foodValue;
            }
            if(gameObject.name == "Cheese" && (Input.GetKeyDown(KeyCode.J)||InputBridge.Instance.BButtonDown))
            {
                Instantiate(cloneObj, new Vector3(10.937f,0.20f,26.1f), Quaternion.identity);
                //newCheese.transform.parent = testObj.transform;
                Debug.Log("Instantiate CheeseSlice");
                GameFlow.plateValue += foodValue;
            }
            if(gameObject.name == "Tomato" && (Input.GetKeyDown(KeyCode.J)||InputBridge.Instance.BButtonDown))
            {
                Instantiate(cloneObj, new Vector3(10.937f,0.12f,26.1f), Quaternion.identity);
                //newTomato.transform.parent = testObj.transform;
                Debug.Log("Instantiate TomatoSlice");
                GameFlow.plateValue += foodValue;
            }
            if(gameObject.name == "BreadBottom" && (Input.GetKeyDown(KeyCode.J)||InputBridge.Instance.BButtonDown))
            {
                Instantiate(cloneObj, new Vector3(10.937f,0.1f,26.1f), Quaternion.identity);
                //newBreadBottom.transform.parent = testObj.transform;
                Debug.Log("Instantiate Burger Bottom");
                GameFlow.plateValue += foodValue;
            }

            //Debug.Log(GameFlow.plateValue + " " + GameFlow.orderValue); 
        }
        
        
    }

    

}
