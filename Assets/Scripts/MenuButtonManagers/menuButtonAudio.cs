using UnityEngine;
using UnityEngine.Audio;

public class menuButtonAudio : MonoBehaviour
{
    public AudioSource UIAudioManager;
    
    public AudioClip menuButtonSound;
    
    public void MenuButtonSound()
    {
        UIAudioManager.PlayOneShot(menuButtonSound);
    }
}
