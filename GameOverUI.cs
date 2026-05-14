using UnityEngine;

public class GameOverUI : MonoBehaviour
{
    public GameObject gameOverPanel;

    private void Update()
    {
        if (GameManager.instance.gameOver)
        {
            gameOverPanel.SetActive(true);

            Time.timeScale = 0f;
        }
    }

    public void Restart()
    {
        Time.timeScale = 1f;
        GameManager.instance.RestartGame();
    }
}
