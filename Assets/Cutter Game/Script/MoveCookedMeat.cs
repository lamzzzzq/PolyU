using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using BNG;

public class MoveCookedMeat : MonoBehaviour
{

    public AudioSource audioData;
    private ParticleSystem ps;
    private int foodValue = 0;
    private MeshRenderer meatMat;
    private bool cooking = true;


    public GameObject cookedMeat;

    //
    public Color colorToTurnTo;
    //public Color defaultColor;


    // Start is called before the first frame update
    void Start()
    {   
        audioData = GetComponent<AudioSource>();
        
        meatMat = GetComponent<MeshRenderer>();
        StartCoroutine(cookTimer());

        ps = GameObject.Find("_meatPar").GetComponent<ParticleSystem>();
        ps.Play();
        
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "Player" && (Input.GetKeyDown(KeyCode.J)||InputBridge.Instance.BButtonDown))
        {
            Instantiate(cookedMeat, new Vector3(10.937f,0.23f,26.1f), Quaternion.identity);
            GameFlow.plateValue += foodValue;
            cooking = false;
            //meatMat.material.color = defaultColor;
            //GameObject.Find("LunchMeatSlice").SetActive(false); //meatBaking in MeatSlice.cs
            Destroy(gameObject);
        }
    }

    IEnumerator cookTimer()
    {
        yield return new WaitForSeconds(10);
        foodValue = 1000;
        if(cooking == true)
        {   
            audioData.Play();
            meatMat.material.color = colorToTurnTo;
            ps.Pause();
            ps.Clear();
            
            
        }

    }
}
