using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PetSpawner : MonoBehaviour
{
    public GameObject[] pets;
    public float minX;
    public float maxX;
    public float minY;
    public float maxY;
    public float timeBetweenSpawn;
    private float spawnTime;
    public string SceneToLoad;
    public float time;

    void Update()
    {
            if (Time.time > spawnTime)
            {
                Spawn();
                spawnTime = Time.time + timeBetweenSpawn;
            }
            time += 1 * Time.deltaTime;
    }

    void Spawn()
    {
        int rnd = Random.Range(0, pets.Length);
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        Instantiate(pets[rnd], transform.position + new Vector3(randomX,randomY , 0), transform.rotation);
    }

}
