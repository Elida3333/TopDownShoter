using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    [SerializeField] GameObject enemyPreFab;
    [SerializeField] float minSpawnTime = 1f;
    [SerializeField] float maxSpawnTime = 3f;
    [SerializeField] float SpawnDistans = 10f;
    Vector2 screenBounds;
    Vector2 spawnPos;
    void Start()
    {
        SpawnEnemy();
        
    }

    
    void SpawnEnemy()
    {
        float spawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));

        int side = Random.Range(0, 4);
        switch (side)
        {

            case 0:
                spawnPos = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), screenBounds.y + SpawnDistans);
                break;
            case 1:
                spawnPos = new Vector2(Random.Range(-screenBounds.x, screenBounds.x), -screenBounds.y - SpawnDistans);
                break;
            case 2:
                spawnPos = new Vector2(screenBounds.x + SpawnDistans, Random.Range(-screenBounds.y, screenBounds.y));
                break;
            case 3:
                spawnPos = new Vector2(-screenBounds.x - SpawnDistans, Random.Range(-screenBounds.y, screenBounds.y));
                break;
        }
        Instantiate(enemyPreFab, spawnPos, transform.rotation);
        Invoke("SpawnEnemy", spawnTime);


    }
}
