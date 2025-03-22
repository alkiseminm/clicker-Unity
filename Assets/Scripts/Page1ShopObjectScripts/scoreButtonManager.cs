using TMPro;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;

public class scoreButtonManager : MonoBehaviour
{
    public scoreManager scoreManager;
    
    public TextMeshProUGUI ButtonText;
    public TextMeshProUGUI CalculateText;

    public int add;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        CalculateAdd();
        UpdateButtonText();
        UpdateCalculatorText();
    }

    // Update is called once per frame
    void Update()
    {
        CalculateAdd();
        UpdateButtonText();
        UpdateCalculatorText();
    }

    void CalculateAdd()
    {
        add = scoreManager.plus * scoreManager.mult;
    }

    void UpdateButtonText()
    {
        if (ButtonText != null)
        {
            ButtonText.text = "+" + add.ToString();
        }
    }

    void UpdateCalculatorText()
    {
        CalculateText.text = "Plus: +" + scoreManager.plus.ToString() + "\n" + "Multiplier : x" + scoreManager.mult.ToString();
    }

    public void ScoreButtonPressed()
    {
        scoreManager.score += add;
    }
}
