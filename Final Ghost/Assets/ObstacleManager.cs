using System.Collections;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{

    [Header("Obstacle Prefab")]
    [SerializeField] GameObject obstaclePrefab;

    [Header("Time interval between obstacles")]
    [SerializeField] float timeInterval;

    [Header("Max and min hight of obstacle")]
    [SerializeField] float maxHight;
    [SerializeField] float minHight;

    private bool gameHasStarted = true;
    
    public void StartObstacleSpawning()
    {
        StartCoroutine(MakeObstacle());
        
    }

    IEnumerator MakeObstacle()
    {
        while (gameHasStarted)
        {
            Instantiate(obstaclePrefab, SetObstacleStartPosition(), Quaternion.identity);
            yield return new WaitForSeconds(timeInterval);
        }

    }

    private Vector3 SetObstacleStartPosition()
    {
        return new Vector3(transform.position.x, Random.Range(minHight, maxHight),
            transform.position.z);
    }

}
