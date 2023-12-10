using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnPosHorizontal = 20.0f;
    private float spawnPosTop = 20.0f;
    private float spawnDelay = 2.0f;
    private float spawnRate = 1.5f;
    // Start is called before the first frame update
    private void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", spawnDelay, spawnRate);
    }

    // Update is called once per frame
    private void Update()
    {
    }

    void SpawnRandomAnimal()
    {
        int prefabIndex = Random.Range(0, animalPrefabs.Length);

        Vector3 spawnPosition = new Vector3(Random.Range(-spawnPosHorizontal, spawnPosHorizontal), 0, spawnPosTop);

        Instantiate(animalPrefabs[prefabIndex], spawnPosition, animalPrefabs[prefabIndex].transform.rotation);
    }
}
