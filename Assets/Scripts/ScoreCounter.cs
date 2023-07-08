using UnityEngine;
using TMPro;

public sealed class ScoreCounter : MonoBehaviour
{
    public static ScoreCounter Instance { get; private set; }

    private int _score;
    private int _bestScore;

    public int Score
    {
        get => _score;
        set
        {
            if (_score == value) return;

            _score = value;

            if (_score > _bestScore)
            {
                _bestScore = _score;
                PlayerPrefs.SetInt("BestScore", _bestScore); // Сохранение лучшего счета
            }

            UpdateScoreText();
            UpdateBestScoreText();
        }
    }

    [SerializeField] private TextMeshProUGUI scoreText;
    [SerializeField] private TextMeshProUGUI bestScoreText;

    private void Awake()
    {
        Instance = this;
        _bestScore = PlayerPrefs.GetInt("BestScore", 0); // Загрузка лучшего счета
        UpdateBestScoreText();
    }

    private void UpdateScoreText()
    {
        scoreText.text = $"Score {_score}";
    }

    private void UpdateBestScoreText()
    {
        bestScoreText.text = $"Best Score {_bestScore}";
    }
}