using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public float spawnInterval = 0.7f;
    public float xRange = 7f;

    private void Start()
    {
        InvokeRepeating(nameof(SpawnObstacle), 1f, spawnInterval);
    }

    void SpawnObstacle()
    {
        if (!GameManager.instance.isPlaying)
            return;

        float x = Random.Range(-xRange, xRange);
        Vector3 pos = new Vector3(x, 6f, 0);

        Instantiate(obstaclePrefab, pos, Quaternion.identity);
    }
}
