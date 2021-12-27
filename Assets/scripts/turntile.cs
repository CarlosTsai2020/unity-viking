using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class turntile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    PlayerMovement playerMovement;


    void Start()
    {
        playerMovement = GameObject.FindObjectOfType<PlayerMovement>();
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnCoin();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
        playerMovement.speed = 10f;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.name == "Viking")
            playerMovement.turnOp = 1;
        playerMovement.speed = 15f;
    }

    public GameObject collectablePreFab;
    void SpawnCoin()
    {
        int coinsToSpawn = 1;
        for (int i = 0; i < coinsToSpawn; i++)
        {
            GameObject temp = Instantiate(collectablePreFab, transform);
            temp.transform.position = GetRandomPointInCollider(GetComponent<Collider>());
        }
    }
    Vector3 GetRandomPointInCollider(Collider collider)
    {
        Vector3 point = new Vector3(
            Random.Range(collider.bounds.min.x, collider.bounds.max.x),
            Random.Range(collider.bounds.min.y, collider.bounds.max.y),
            Random.Range(collider.bounds.min.z, collider.bounds.max.z)
            );
        if (point != collider.ClosestPoint(point))
        {
            point = GetRandomPointInCollider(collider);
        }

        point.y = 1;
        return point;
    }
}
