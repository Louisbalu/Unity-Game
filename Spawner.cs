using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 2f; // Time between obstacle spawns
    public float obstacleSpeed = 5f; // Speed at which the obstacle moves from right to left

    void Start()
    {
        // Start spawning obstacles at intervals
        InvokeRepeating("SpawnObstacle", 0f, spawnInterval);
    }

    void SpawnObstacle()
    {
        // Instantiate the obstacle at a starting position on the right side
        GameObject obstacle = Instantiate(obstaclePrefab, new Vector3(10f, Random.Range(-4f, 4f), 0f), Quaternion.identity);

        // Set the obstacle's speed to move from right to left
        Rigidbody2D obstacleRb = obstacle.GetComponent<Rigidbody2D>();
        if (obstacleRb != null)
        {
            obstacleRb.velocity = new Vector2(-obstacleSpeed, 0f);
        }
    }
}
