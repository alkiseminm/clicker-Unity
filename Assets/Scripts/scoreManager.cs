using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ButtonText;

    public int plus = 1;
    public int mult = 1;
    public int add;

    public int score = 0;

    private void Update()
    {
        CalculateAdd();
        UpdateScoreUI();
        UpdateButtonText();
    }

    void CalculateAdd()
    {
        add = plus * mult;
    }
    
    void UpdateButtonText()
    {
        if (ButtonText != null)
        {
            ButtonText.text = "+" + add.ToString();
        }
    }

    void UpdateScoreUI()
    {
        scoreText.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score += add;
    }

    void Start()
    {
        add = plus * mult;
        
        UpdateScoreUI();
        UpdateButtonText();
    }

    
}
