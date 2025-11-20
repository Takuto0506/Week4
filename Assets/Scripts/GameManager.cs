using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public bool isPlaying = true;

    private void Awake()
    {
        instance = this;
    }

    public void GameOver()
    {
        if (!isPlaying) return;

        isPlaying = false;
        UIManager.instance.ShowGameOverUI();
    }

    public void Retry()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(0);
    }
}
