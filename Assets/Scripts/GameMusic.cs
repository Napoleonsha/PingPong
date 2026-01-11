using UnityEngine;

public class GameMusic : MonoBehaviour
{
    AudioSource audioSource;
    AudioSource SFX;

    public void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        float savedVolume = PlayerPrefs.GetFloat("Volume", 1f);
        audioSource.volume = savedVolume;
        audioSource.Play();
        SFX.volume = savedVolume;

    }
}