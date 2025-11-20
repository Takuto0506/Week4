using UnityEngine;

public class TriangleSpawner : MonoBehaviour
{
    public GameObject trianglePrefab; // ‹tOŠpŒ`‚ÌPrefab
    public float spawnInterval = 1f;  // ¶¬ŠÔŠu

    private float timer = 0f;

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer >= spawnInterval)
        {
            SpawnTriangle();
            timer = 0f;
        }
    }

    void SpawnTriangle()
    {
        // ‰æ–Êã‚Ìƒ‰ƒ“ƒ_ƒ€‚ÈˆÊ’u‚É¶¬
        float x = Random.Range(-3.5f, 3.5f);
        Vector3 pos = new Vector3(x, 6f, 0f);

        Instantiate(trianglePrefab, pos, Quaternion.identity);
    }
}
