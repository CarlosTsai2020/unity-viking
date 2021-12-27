using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obstacleSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        SpawnObstacle();
    }

    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleIndex = Random.Range(2,5);
        Vector3 spawnPoint = transform.GetChild(obstacleIndex).position;
        Instantiate(obstaclePrefab, spawnPoint, Quaternion.identity, transform);
    }
}
