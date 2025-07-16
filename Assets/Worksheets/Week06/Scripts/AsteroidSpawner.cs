using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    public GameObject asteroidPrefab;
    public int maxAsteroids = 4;

    void Start()
    {
        StartCoroutine(SpawnAsteroids());
    }

    IEnumerator SpawnAsteroids()
    {
        for (int i = 0; i < maxAsteroids; i++)
        {
            Vector2 screenPosition = new Vector2(Random.Range(0f, Screen.width), Random.Range(0f, Screen.height));

            Vector3 worldPosition = Camera.main.ScreenToWorldPoint(new Vector3(screenPosition.x, screenPosition.y, 10f));
            Instantiate(asteroidPrefab, worldPosition, Quaternion.identity);

            yield return new WaitForSeconds(0.5f);
        }
    }
}

