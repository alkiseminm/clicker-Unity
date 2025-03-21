using TMPro;
using UnityEngine;

public class buyPlusButtonManager : MonoBehaviour
{
    public scoreManager scoreManager;
    public pageManager pageManager;

    public GameObject BuyPlusButton;
    public TextMeshProUGUI ProductNamePlus;
    public TextMeshProUGUI PriceBuyPlus;
    
    public int buyPlusCost = 10;
    public int buyPlus = 1;

    private void Start()
    {
        Exist();
        UpdateBuyPlusButtonText();
        UpdatePriceBuyPlusText();
    }

    public void BuyPlusButtonPressed()
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

    void Exist()
    {
        if (pageManager.page == 1)
        {
            BuyPlusButton.SetActive(true);
        }
        else
        {
            BuyPlusButton.SetActive(false);
        }
    }
}
