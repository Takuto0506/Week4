using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager instance;

    public Button retryButton;

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        retryButton.gameObject.SetActive(false);
    }

    public void ShowGameOverUI()
    {
        retryButton.gameObject.SetActive(true);
    }
}
