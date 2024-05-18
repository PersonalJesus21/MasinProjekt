using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using JetBrains.Annotations;

public class LogicManager : MonoBehaviour

{
   
    public GameObject gameOverScreen;
   public int PlayerHealth;
   public int PlayerScore;
   public TextMeshProUGUI HealthText;
   public TextMeshProUGUI ScoreText;
  public TextMeshProUGUI HighScoreText;
    public void Start()
    {
        UpdateHighScoreText();
        Time.timeScale = 1;
    }
   public void AddScore()
    {
        PlayerScore = PlayerScore + 1;
        ScoreText.text = PlayerScore.ToString();
        CheckingHScore();
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
   
    public void CheckingHScore()
    {
       if (PlayerScore > PlayerPrefs.GetInt("HighScore", 0))
       {
        PlayerPrefs.SetInt("HighScore", PlayerScore);
        Debug.Log("Funguje");
       }
    }
    public void UpdateHighScoreText()
    {
        Debug.Log("Updated");
        HighScoreText.text = $" {PlayerPrefs.GetInt("HighScore", 0)}";
    }
}
