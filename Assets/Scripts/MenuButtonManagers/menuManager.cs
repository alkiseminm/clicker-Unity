using UnityEngine;

public class menuManager : MonoBehaviour
{
    public bool isMenuOpen;

    public GameObject Page1ButtonShop;
    public GameObject Page2ButtonInterest;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        isMenuOpen = false;
    }

    public void MenuButtonPressed()
    {
        if (isMenuOpen == false)
        {
            isMenuOpen = true;
        }
        else
        {
            isMenuOpen = false;
        }
    }

    public void Page1ButtonShopExist()
    {
        if (isMenuOpen == true)
        {
            Page1ButtonShop.SetActive(true);
        }
        if (isMenuOpen == false)
        {
            Page1ButtonShop.SetActive(false);
        }
    }

    public void Page2ButtonInterestExist()
    {
        if (isMenuOpen == true)
        {
            Page2ButtonInterest.SetActive(true);
        }
        if (isMenuOpen == false)
        {
            Page2ButtonInterest.SetActive(false);
        }
    }
}
