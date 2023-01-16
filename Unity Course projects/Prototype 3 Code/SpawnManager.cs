using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject spawn;
    private Vector3 spawnPos = new Vector3(25, 0, 0);
    private float startTime = 2;
    private float waitTime = 2;
    private PlayerController playerController;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnObstacle", startTime, waitTime);
        playerController=GameObject.Find("Player").GetComponent<PlayerController>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void spawnObstacle()
    {
        if (playerController.gameOver == false)
        {
            Instantiate(spawn, spawnPos, spawn.transform.rotation);
        }


    }
}
