using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] fruitsPrefabs;
    public Vector2 spawnPosition;
    public float startTime;
    public float repeatRate;
    public float minSpawnXPosition;
    public float maxSpawnXPosition;

    private void Start()
    {
        InvokeRepeating(nameof(spawnObject), startTime, repeatRate);
    }

    private void spawnObject()
    {
        float randomSpawnPosition = Random.Range(minSpawnXPosition, maxSpawnXPosition);
        int randomFruitIndex = Random.Range(0, fruitsPrefabs.Length);
        Instantiate(fruitsPrefabs[randomFruitIndex], new Vector2(randomSpawnPosition,spawnPosition.y), Quaternion.identity);
    }


}
