using UnityEngine;

public class CheeseSpawner : MonoBehaviour
{
    public GameObject cheesePrefab;

    public float minX = -9f;
    public float maxX = 9f;
    public float minY = -4f;
    public float maxY = 4f;

    void Start()
    {
        SpawnCheese();
    }

    public void SpawnCheese()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Vector2 spawnPosition = new Vector2(randomX, randomY);

        Instantiate(cheesePrefab, spawnPosition, Quaternion.identity);
    }
}
