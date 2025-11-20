using UnityEngine;

public class Triangle : MonoBehaviour
{
    private void Update()
    {
        // 画面外（Y座標 -6 以下）で消す
        if (transform.position.y < -6f)
        {
            Destroy(gameObject);
        }
    }
}
