using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text playerScoreText;
    public int playerScore = 0;
    public Text playerHighScoreText;
    public int playerHighScore = 0;
    private float timer = 0;
    public float scoreIncreaseRate = 0.25f;

    void Update()
    {
        if (timer < scoreIncreaseRate)
        {
            timer += Time.deltaTime;
        } else
        {
            addScore();
            timer = 0;
        }
    }

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore += 1;
        playerScoreText.text = playerScore.ToString();
    }

    [ContextMenu("Set High Score")]
    void setHighScore() // needs to be called at gameover
    {
        if (playerScore > playerHighScore)
        {
            playerHighScore = playerScore;
            playerHighScoreText.text = playerHighScore.ToString();
        }
    }
}
