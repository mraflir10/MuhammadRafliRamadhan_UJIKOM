using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameOverUIController : MonoBehaviour
{
    public Button retryButton;
    public Button menuButton;

    public TimeManager timeManager;

    public PlayerController playerController;

    void Start()
    {
        retryButton.onClick.AddListener(RetryGame);
        menuButton.onClick.AddListener(MenuGame);

    }

    private void RetryGame()
    {
        SceneManager.LoadScene("Main");
    }

    private void MenuGame()
    {
        SceneManager.LoadScene("MainMenu");
    }

    // Update is called once per frame
    void Update()
    {

    }
}
