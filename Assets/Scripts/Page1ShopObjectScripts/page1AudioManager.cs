using UnityEngine;
using UnityEngine.Audio;

public class page1AudioManager : MonoBehaviour
{
    public AudioSource Page1AudioManager;
    
    public AudioClip buySound;
    public AudioClip scoreButtonSound;

    public void BuyButtonSound()
    {
        Page1AudioManager.PlayOneShot(buySound);
    }

    public void ScoreButtonSound()
    {
        Page1AudioManager.PlayOneShot(scoreButtonSound);
    }
}
