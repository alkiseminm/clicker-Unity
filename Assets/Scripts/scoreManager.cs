using UnityEngine;
using TMPro;
using Unity.VisualScripting;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI scoreText;

    public int plus = 1;
    public int mult = 1;

    public int score = 0;
    
    void Start()
    {
        UpdateScoreText();
    }

    private void Update()
    {
        UpdateScoreText();
    }

    void UpdateScoreText()
    {
        scoreText.text = score.ToString();
    }
}
