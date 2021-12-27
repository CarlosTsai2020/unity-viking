using UnityEngine;

public class GroundSpawner : MonoBehaviour
{
    public GameObject groundTiles;
    public GameObject gap;
    public GameObject stairgap;
    public GameObject turnRight;
    public GameObject turnLeft;
    public GameObject bridge;
    public GameObject shortTiles;
    
    Quaternion currentDirection;
    bool turnright;

    Vector3 nextSpawnPoint = new Vector3(0, 0, 5.48f);

    public void SpawnTile()
    {
        GameObject temp;
        switch (Random.Range(0, 10))
        {
            case 0:
                temp = Instantiate(gap, nextSpawnPoint, currentDirection);
                break;
            case 1:
                if (turnright)
                {
                    temp = Instantiate(turnRight, nextSpawnPoint, currentDirection);
                    currentDirection *= Quaternion.Euler(0, 90, 0);
                }
                else
                {
                    temp = Instantiate(turnLeft, nextSpawnPoint, currentDirection);
                    currentDirection *= Quaternion.Euler(0, -90, 0);
                }
                turnright = !turnright;
                break;
            case 2:
                temp = Instantiate(shortTiles, nextSpawnPoint, currentDirection);
                break;
            case 3:
                temp = Instantiate(bridge, nextSpawnPoint, currentDirection);
                break;
            case 4:
                temp = Instantiate(stairgap, nextSpawnPoint, currentDirection);
                break;
            default:
                temp = Instantiate(groundTiles, nextSpawnPoint, currentDirection);
                break;
        }
        nextSpawnPoint = temp.transform.GetChild(0).transform.position;
    }

    void Start()
    {
        currentDirection = Quaternion.Euler(0, 0, 0);
        for (int i = 0; i < 60; i++)
            SpawnTile();
    }
}
