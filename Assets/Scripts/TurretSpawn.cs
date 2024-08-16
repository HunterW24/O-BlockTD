using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPrefab : MonoBehaviour
{
    public GameObject prefabToSpawn; // Reference to the prefab
    public Transform spawnPoint; // Optional: Specify a spawn position

    public void Spawn()
    {
        Instantiate(prefabToSpawn, spawnPoint.position, spawnPoint.rotation);
    }
}
