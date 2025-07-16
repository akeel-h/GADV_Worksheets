using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject AsteroidPrefab; 
    public int numberOfAsteroids = 2; // Number of asteroids to spawn
    public Vector2 spawnRangeX = new Vector2(-5f, 5f); // X pos range
    public Vector2 spawnRangeY = new Vector2(-3f, 3f); // Y pos range

    void Start()
    {
        SpawnAsteroids();
    }

    void SpawnAsteroids()
    {
        for (int i = 0; i < numberOfAsteroids; i++)
        {
            Vector3 randomPosition = new Vector3(
                    Random.Range(spawnRangeX.x, spawnRangeX.y),
                    Random.Range(spawnRangeY.x, spawnRangeY.y),
                    0f);

            GameObject asteroid = Instantiate(
                                    AsteroidPrefab,
                                    randomPosition,
                                    Quaternion.identity);

            float timeDestroy = Random.Range(1, 6);
            Destroy(asteroid, timeDestroy);
        }
    }
}
    



