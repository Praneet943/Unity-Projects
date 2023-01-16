using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosX = 10;
    private float spawnPosZ = 20;
   

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnNewBall", 2, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
    

    }

    void SpawnNewBall()
    {
        int animalindex = Random.Range(0, animalPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnPosX, spawnPosX), 0, spawnPosZ);
        Instantiate(animalPrefabs[animalindex], spawnPos, animalPrefabs[animalindex].transform.rotation);
    }
}
