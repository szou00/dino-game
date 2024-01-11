using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LogicScript : MonoBehaviour
{
    public Text playerScoreText;
    public int playerScore;

    [ContextMenu("Increase Score")]
    public void addScore()
    {
        playerScore += 1;
        playerScoreText.text = playerScore.ToString();
    }
}
