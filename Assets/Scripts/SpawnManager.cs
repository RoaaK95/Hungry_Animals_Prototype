using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spwanRangeX = 20.0f;
    private float topSpawnZ = 20.0f;
    private float spwanRangeZ = 5.0f;
    private float sideSpawnX = 30.0f;
    private float startDelay = 2.0f;
    private float spwanInterval = 3.0f;
    
    



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpwanLeftAnimals", startDelay, spwanInterval);
        InvokeRepeating("SpwanTopAnimals", startDelay, spwanInterval);
        InvokeRepeating("SpwanRightAnimals", startDelay, spwanInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Randomly generate animal index and spwan position
    void SpwanTopAnimals()
    {

        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spwanPosX = new Vector3(Random.Range(-spwanRangeX, spwanRangeX), 0, topSpawnZ);
        Instantiate(animalPrefabs[animalIndex], spwanPosX, animalPrefabs[animalIndex].transform.rotation);

    }

    void SpwanRightAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spwanPosZ = new Vector3(sideSpawnX, 0, Random.Range(-spwanRangeZ, spwanRangeZ));
        Vector3 rotation = new Vector3(0, -90, 0);
        Instantiate(animalPrefabs[animalIndex], spwanPosZ, Quaternion.Euler(rotation));
    }
    void SpwanLeftAnimals()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length);
        Vector3 spwanPosZ = new Vector3(-sideSpawnX, 0, Random.Range(-spwanRangeZ, spwanRangeZ));
        Vector3 rotation = new Vector3(0, 90, 0);
        Instantiate(animalPrefabs[animalIndex], spwanPosZ, Quaternion.Euler(rotation));

    }
}
