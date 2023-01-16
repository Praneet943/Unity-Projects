using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float waitTime = 1.0f;
    private float startTime = 2.0f;
    private bool canSpawn;

    void Start()
    {
        InvokeRepeating("canSpawnDog", startTime, waitTime);
    }


    // Update is called once per frame
    void Update()
    {

        // On spacebar press, send dog


        if (Input.GetKeyDown(KeyCode.Space) && canSpawn)
        {
            Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);
            canSpawn = false;
        }

    }

    void canSpawnDog()
    {
        canSpawn=true;
    }

}