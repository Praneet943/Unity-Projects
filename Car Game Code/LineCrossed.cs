using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineCrossed : MonoBehaviour
{
    public Text LapCounter;
    public GameObject Complete;
    public GameObject HalfWay;
    public int Lapsdone;
   
    void OnTriggerEnter()
    {
        Lapsdone+=1;
        LapCounter.text= Lapsdone.ToString();
        Complete.SetActive(false);
        HalfWay.SetActive(true);
        
    }

  
}
