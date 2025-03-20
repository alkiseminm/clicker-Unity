using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class scoreManager : MonoBehaviour
{
    public int plus = 1;
    public int mult = 1;
    public int add;

    public int score = 0;
    public TextMeshProUGUI scoreText; // For TextMeshPro

    void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }

    public void IncreaseScore()
    {
        add = plus * mult;
        
        score += add;
        
        UpdateScoreUI();
    }

    void Start()
    {
        add = plus * mult;
        
        UpdateScoreUI();
    }

    
}
