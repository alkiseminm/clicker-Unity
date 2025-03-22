using UnityEngine;

public class page2ButtonInterestManager : MonoBehaviour
{
    public menuManager menuManager;
    public pageManager pageManager;

    public GameObject Page2ButtonInterest;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Exist();
    }

    void Exist()
    {
        if (menuManager.isMenuOpen == true)
        {
            Page2ButtonInterest.SetActive(true);
        }
        if (menuManager.isMenuOpen == false)
        {
            Page2ButtonInterest.SetActive(false);
        }
    }

    public void Page2ButtonInterestPressed()
    {
        pageManager.page = 2;
    }
}
