using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LineCrossed : MonoBehaviour
{
    //Variables

    public Text LapCounter;
    public GameObject Complete;
    public GameObject HalfWay;
    public int Lapsdone;
   
    //Method runs when the Finish Line object is crossed
    void OnTriggerEnter()
    {
        //Increments laps and assigns the text of the laps section to the new value

        Lapsdone+=1;
        LapCounter.text= Lapsdone.ToString();
        Complete.SetActive(false);
        HalfWay.SetActive(true);
        
    }

  
}
