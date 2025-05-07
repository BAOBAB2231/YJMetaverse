using UnityEngine;
using TMPro;

public class MainSceneUIManager : MonoBehaviour
{
    public TextMeshProUGUI lastScoreText;
    public TextMeshProUGUI bestScoreText;

    void Start()
    {
        int lastScore = PlayerPrefs.GetInt("LastScore", 0);
        int bestScore = PlayerPrefs.GetInt("HighScore", 0);

        if (lastScoreText != null)
            lastScoreText.text = $"lastScore: {lastScore}";

        if (bestScoreText != null)
            bestScoreText.text = $"bestScore: {bestScore}";
    }
}