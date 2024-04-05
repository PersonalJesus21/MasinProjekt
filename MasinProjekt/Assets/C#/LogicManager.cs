using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LogicManager : MonoBehaviour

{
    public GameObject gameOverScreen;
   public int PlayerHealth;
   public int PlayerScore;
   public TextMeshProUGUI HealthText;
   public TextMeshProUGUI ScoreText;
  [ContextMenu("Increase Score")]
   public void AddScore()
    {
        PlayerScore = PlayerScore + 1;
        ScoreText.text = PlayerScore.ToString();
    }

    public void DecreaseHealth()
    {
        PlayerHealth = PlayerHealth - 25;
        HealthText.text = PlayerHealth.ToString();
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void gameOver()
    {
        gameOverScreen.SetActive(true);
    }
}
