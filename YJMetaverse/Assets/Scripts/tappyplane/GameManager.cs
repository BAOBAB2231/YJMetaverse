using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static GameManager gameManager;

    public static GameManager Instance
    {
        get { return gameManager; }
    }

    private int currentScore = 0;
    private bool isGameOver = false;
    UIManager uiManager;

    public UIManager UIManager
    {
        get { return uiManager; }
    }
    private void Awake()
    {
        gameManager = this;
        uiManager = FindObjectOfType<UIManager>();
    }

    private void Start()
    {
        uiManager.UpdateScore(0);
    }

    public void GameOver()
    {
        if (isGameOver) return;
        isGameOver = true;
        uiManager.SetRestart();
        SaveScore();
    }

    public void ReturnToMainScene()
    {
        SceneManager.LoadScene("MainScene");
    }

    public void AddScore(int score)
    {
        if (isGameOver) return;

        currentScore += score;
        uiManager.UpdateScore(currentScore);
        Debug.Log("Score: " + currentScore);
    }

    public void SaveScore()
    {
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);

        if (currentScore > bestScore)
        {
            PlayerPrefs.SetInt("HighScore", currentScore);
        }

        PlayerPrefs.SetInt("LastScore", currentScore);
        PlayerPrefs.Save();
    }

}