using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemSpawner : MonoBehaviour
{
    [SerializeField] Item[] itemPrefabs;

    public void SpawnRandomItem()
    {
        Item randomItem = Instantiate(itemPrefabs[Random.Range(0, itemPrefabs.Length)], transform.position, Quaternion.identity);
        Debug.Log("Random Item Spawned");
    }
}
