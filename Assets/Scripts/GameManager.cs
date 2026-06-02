using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public TMP_Text scoreText;
    public TMP_Text timerText;

    public GameObject gameOverPanel;

    int score = 0;
    float timer = 300f;

    void Awake()
    {
        instance = this;
    }

    void Update()
    {
        timer -= Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        timerText.text =
            minutes.ToString("00")
            + ":" +
            seconds.ToString("00");

        if (timer <= 0)
        {
            GameOver();
        }
    }

    public void AddScore(int amount)
    {
        score += amount;
        scoreText.text = "Score: " + score;
    }

    void GameOver()
    {
        Time.timeScale = 0;
        gameOverPanel.SetActive(true);
    }
}