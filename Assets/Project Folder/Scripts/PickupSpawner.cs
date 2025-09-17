using System;
using System.Collections.Generic;
using UnityEngine;

public class PickupSpawner : MonoBehaviour
{
    public GameObject pickupPrefab; // The prefab for the pickup item
    public int maxPickups = 5; // Maximum number of pickups allowed in the scene
    private List<GameObject> spawnPickups;
    public BoxCollider spawnArea; // The area within which pickups can spawn
    public float closePointDistance = 0.5f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnPickups = new List<GameObject>();
        // Spawn the initial pickups at the start of the game
        SpawnPickups(maxPickups);
    }

    // Update is called once per frame
    void Update()
    {
        int counter = spawnPickups.Count;
        // Check if the number of pickups has dropped below the maximum
        if (counter < maxPickups)
        {
            SpawnPickups(maxPickups - counter);
        }
    }


    // Spawns a specified number of pickups within the spawn area.
    private void SpawnPickups(int numberToSpawn)
    {
        for (int i = 0; i < numberToSpawn; i++)
        {
            Vector3 spawnPosition = GetRandomPointInBoxCollider();
            GameObject newPickup = Instantiate(pickupPrefab, spawnPosition, Quaternion.identity);
            spawnPickups.Add(newPickup);
        }
    }


    // Generates a random position within the defined BoxCollider.
    private Vector3 GetRandomPointInBoxCollider()
    {
        // Get the bounds of the BoxCollider
        Bounds bounds = spawnArea.bounds;

        // Calculate a random point within those bounds
        float randomX = UnityEngine.Random.Range(bounds.min.x, bounds.max.x);
        float randomY = UnityEngine.Random.Range(bounds.min.y, bounds.max.y);
        float randomZ = UnityEngine.Random.Range(bounds.min.z, bounds.max.z);

        if(IsTooClose(new Vector3(randomX,randomY,randomZ)))
        {
            randomX /= 2;
            randomY /= 2;
            randomZ /= 2;
        }

        // Return the random position
        return new Vector3(randomX, randomY, randomZ);
    }

    private Boolean IsTooClose(Vector3 point)
    {
        foreach (GameObject pref in spawnPickups)
        {
            if (Vector3.Distance(pref.transform.position, point) < closePointDistance)
            {
                return true;
            }
        }
        return false;
    }
}