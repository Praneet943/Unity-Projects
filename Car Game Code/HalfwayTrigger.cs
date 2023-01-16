using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HalfwayTrigger : MonoBehaviour
{
    public GameObject halfway;
    public GameObject complete;

    private void OnTriggerEnter()
    {
        complete.SetActive(true);
        halfway.SetActive(false);
    }
}
