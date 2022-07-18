using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ShowName : MonoBehaviour
{   
    public GameObject UIShow;

    // Start is called before the first frame update
    void Start()
    {
        UIShow.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            UIShow.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            UIShow.SetActive(false);
        }
    } 


}
