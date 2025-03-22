using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI ButtonText;
    public TextMeshProUGUI CalculateText;

    public int plus = 1;
    public int mult = 1;
    public int add;

    public int score = 0;
    
    void Start()
    {
        CalculateAdd();
        UpdateScoreText();
        UpdateButtonText();
        UpdateCalculatorText();
    }

    private void Update()
    {
        CalculateAdd();
        UpdateScoreText();
        UpdateButtonText();
        UpdateCalculatorText();
    }

    void CalculateAdd()
    {
        add = plus * mult;
    }
    
    void UpdateCalculatorText()
    {
        CalculateText.text = "Plus: +" + plus.ToString() + "\n" + "Multiplier : x" + mult.ToString();
    }
    
    void UpdateButtonText()
    {
        if (ButtonText != null)
        {
            ButtonText.text = "+" + add.ToString();
        }
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }

    public void IncreaseScore()
    {
        score += add;
    }
}
