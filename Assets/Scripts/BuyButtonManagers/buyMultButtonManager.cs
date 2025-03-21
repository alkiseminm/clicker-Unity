using TMPro;
using UnityEngine;

public class buyMultButtonManager : MonoBehaviour
{
    public scoreManager scoreManager;
    public pageManager pageManager;

    public GameObject BuyMultButton;
    public TextMeshProUGUI ProductNameMult;
    public TextMeshProUGUI PriceBuyMult;

    public int buyMultCost = 10;
    public int buyMult = 1;

    private void Start()
    {
        Exist();
        UpdateBuyMultButtonText();
        UpdatePriceBuyMultText();
    }

    public void BuyMultButtonPressed()
    {
        if (scoreManager.score >= buyMultCost)
        {
            scoreManager.score -= buyMultCost;
            buyMultCost += buyMultCost * buyMult;
            scoreManager.mult += buyMult;
            buyMult += 1;

            UpdateBuyMultButtonText();
            UpdatePriceBuyMultText();
        }
    }

    public void UpdatePriceBuyMultText()
    {
        PriceBuyMult.text = "Price: " + buyMultCost.ToString();
    }

    void UpdateBuyMultButtonText()
    {
        ProductNameMult.text = "+" + buyMult.ToString() + " Multiplier";
    }

    void Exist()
    {
        if (pageManager.page == 1)
        {
            BuyMultButton.SetActive(true);
        }
        else
        {
            BuyMultButton.SetActive(false);
        }
    }
}
