using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTrigger : MonoBehaviour
{
    public GameObject halfway;
    public GameObject complete;
   
    //Method runs when the car goes through the invisible object
    private void OnTriggerEnter()
    {
        /*If the car reaches the invisible object at the halfway point, the invisible object at the finish line will be active
         * This is to make sure that the user actually goes through race course and does not cheat to get laps, the user has to go 
         * to the halfway point on the track which will activate the invisible object at the finish line, once the car reaches that
         * invisible object, the laps are incremented.*/
        
        complete.SetActive(true);
        halfway.SetActive(false);
    }
}
