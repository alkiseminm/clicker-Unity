using UnityEngine;

public class page1ButtonShopManager : MonoBehaviour
{
    public menuManager menuManager;

    public GameObject Page1ButtonShop;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Exist();
    }

    void Exist()
    {
        if (menuManager.isMenuOpen == true)
        {
            Page1ButtonShop.SetActive(true);
        }
        if (menuManager.isMenuOpen == false)
        {
            Page1ButtonShop.SetActive(false);
        }
    }
}
