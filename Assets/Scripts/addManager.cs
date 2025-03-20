using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class addManager : MonoBehaviour
{
    public scoreManager scoreManager;
    public TextMeshProUGUI ButtonText;

    void Start()
    {
        UpdateButtonText();
    }

    private void Update()
    {
        UpdateButtonText();
    }

    void UpdateButtonText()
    {
        if (ButtonText != null)
        {
            ButtonText.text = "+" + scoreManager.add.ToString();
        }
    }
}
