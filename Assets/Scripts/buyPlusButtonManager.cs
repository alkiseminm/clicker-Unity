using TMPro;
using UnityEngine;

public class buyPlusButtonManager : MonoBehaviour
{
    public scoreManager scoreManager;
    public TextMeshProUGUI ProductNamePlus;
    public TextMeshProUGUI PriceBuyPlus;
    
    public int buyPlusCost = 10;
    public int buyPlus = 1;

    private void Start()
    {
        UpdateBuyPlusButtonText();
        UpdatePriceBuyPlusText();
    }

    public void BuyPlus()
    {
        if (scoreManager.score >= buyPlusCost)
        {
            scoreManager.score -= buyPlusCost;
            buyPlusCost += buyPlusCost * buyPlus;
            scoreManager.plus += buyPlus;
            buyPlus += 1;

            UpdateBuyPlusButtonText();
            UpdatePriceBuyPlusText();
        }
    }

    public void UpdatePriceBuyPlusText()
    {
        PriceBuyPlus.text = "Price: " + buyPlusCost.ToString();
    }

    void UpdateBuyPlusButtonText()
    {
        ProductNamePlus.text = "+" + buyPlus.ToString() + " Plus";
    }
}
