using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateOutlineWhenTriggerStay : MonoBehaviour
{
    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player")
        {
            this.GetComponent<Outline>().enabled = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            this.GetComponent<Outline>().enabled = false;
        }
    }

}
