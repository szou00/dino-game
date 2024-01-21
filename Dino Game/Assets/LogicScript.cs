using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicScript : MonoBehaviour
{
    public int score = 0;
    public int highScore = 0;
    public Text scoreText;
    public Text highScoreText;
    public float scoreIncreaseRate = 0.25f;
    private float timer = 0;
    public GameObject gameOverScreen;
    public AudioSource gameOverSFX;

    void Start()
    {
        highScore = PlayerPrefs.GetInt("High Score", 0);
        highScoreText.text = highScore.ToString();
        gameOverSFX.volume *= .25f;
    }

    void Update()
    {
        if (timer < scoreIncreaseRate)
        {
            timer += Time.deltaTime;
        }
        else
        {
            addScore();
            timer = 0;
        }
    }

    public void addScore()
    {
        score += 1;
        scoreText.text = score.ToString();
    }

    [ContextMenu("Set High Score")]
    void setHighScore()
    {
        if (score > highScore)
        {
            highScore = score;
            highScoreText.text = highScore.ToString();
            PlayerPrefs.SetInt("High Score", highScore);
        }
    }

    public void restartGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        Time.timeScale = 0;
        setHighScore();
        gameOverSFX.Play();
        gameOverScreen.SetActive(true);
        
    }
}