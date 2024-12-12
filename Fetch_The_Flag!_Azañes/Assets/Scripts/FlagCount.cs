using UnityEngine;
using UnityEngine.UI;

public class FlagCount : MonoBehaviour
{
    public static FlagCount Instance { get; private set; } 

    public int score = 0; 
    public Text scoreText;
    public int loop = 0;

    void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject); 
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void Start()
    {
        score = 0;
        loop = 0;
        UpdateScoreText();
    }

    public int IncreaseScore(int amount)
    {
        score += amount;
        loop++;
        UpdateScoreText();

        return score;
    }

    void UpdateScoreText()
    {
        if (scoreText != null && loop < 11)
        {
            scoreText.text = "FLAGS : " + score;
        }
        else
        {
            score = 0;
            loop = 0;
            UpdateScoreText();
        }
        
    }
}