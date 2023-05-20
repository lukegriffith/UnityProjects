using System.Collections;
using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public GameObject foodPrefab;  // Assign your food prefab in the Inspector
    public float spawnInterval = 5f;  // Time in seconds between spawns
    Vector2 screenBounds;

    void Start()
    {
        // Get screen bounds in world coordinates
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, Camera.main.transform.position.z));
        // Start the spawn coroutine
        StartCoroutine(SpawnFood());
    }

    IEnumerator SpawnFood()
    {
        // This loop runs indefinitely
        while (true)
        {
            // Wait for the specified interval
            yield return new WaitForSeconds(spawnInterval);

            // Generate a random position within the screen bounds
            Vector3 randomPosition = new Vector3(Random.Range(-screenBounds.x, screenBounds.x), Random.Range(-screenBounds.y, screenBounds.y), 0f);

            // Instantiate a new food object at the random position
            Instantiate(foodPrefab, randomPosition, Quaternion.identity);
        }
    }
}
