using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerVertical : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] animalPrefabs;

    public float spawnRangeX = 20;
    public float spawnRangeZ = 5;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", 3f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {


    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPos = new Vector3(-22, 0, Random.Range(spawnRangeX, spawnRangeZ));
        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
}
